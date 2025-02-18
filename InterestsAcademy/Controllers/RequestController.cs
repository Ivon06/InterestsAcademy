using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Request;
using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class RequestController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;
        private readonly IRequestService requestService;
        private readonly IUserService userService;
        public RequestController(ICourseService courseService, ITeacherService teacherService, IRequestService requestService, IStudentService studentService, IUserService userService)
        {
            this.courseService = courseService;
            this.teacherService = teacherService;
            this.requestService = requestService;
            this.studentService = studentService;
            this.userService = userService;
        }

        [HttpGet]
        
        public async Task<IActionResult> CreateView( string courseId)
        {
            if (!User.IsInRole("Student"))
            {
                TempData[ErrorMessage] = "Трябва да сте ученик, за да се запишете";
                return RedirectToAction("Index", "Home");
            }

            bool isValidCourse = await courseService.IsCourseValid(courseId);

            if (!isValidCourse)
            {
                TempData[ErrorMessage] = "Този курс не съществува.";
                return RedirectToAction("Index", "Home");
            }

            bool isInCourse = await studentService.IsStudentInCourse(User.GetId(),courseId);
            if (isInCourse)
            {
                TempData[ErrorMessage] = "Ученикът вече е записан за този курс.";
                return RedirectToAction("All", "Course");
            }

            string courseName = await courseService.GetCourseNameById(courseId);
            var user = await userService.GetByIdAsync(User.GetId());
            string studentName = user.Name;
            string email = user.Email;


            return View("Create",new List<string>() { courseName, studentName, email });

        }

        [HttpPost]
        [Route("Request/Create")]
        public async Task<IActionResult> Create(string courseName, string studentName, string studentEmail)
        {
            var teacherId = await teacherService.GetTeacherIdByCourseNameAsync(courseName);

            if (!User.IsInRole("Student"))
            {
                TempData[ErrorMessage] = "Трябва да сте ученик, за да се запишете";
                return RedirectToAction("Index", "Home");
            }

            if(teacherId == null)
            {
                TempData[ErrorMessage] = "Този курс не съществува.";
                return RedirectToAction("All", "Course");
            }

            var isNameValid = await studentService.IsNameValid(studentName);
            var isEmailValid = await studentService.IsEmailValid(studentEmail);

            var user = await userService.GetByIdAsync(User.GetId());

            

            if (!isNameValid || !isEmailValid || studentEmail != user.Email ||studentName != user.Name)
            {

                TempData[ErrorMessage] = "Невалидно име или имейл.";
                return View("Create", courseName);
            }

            

            string requestId;
            try
            {
                var courseId = await courseService.GetCourseIdByName(courseName);
                var studentId = await studentService.GetStudentId(User.GetId());

                var model = new CreateRequestModel();

                model.TeacherId = teacherId;
                model.StudentId = studentId;
                model.Status = RequestStatusEnum.Waiting.ToString();
                model.CourseId = courseId;

                requestId = await requestService.Create(model);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;
                return RedirectToAction("All", "Course");
            }

            TempData[SuccessMessage] = "Успешно записване за курс. Изчакайте одобрение.";

            string teacherUserId = await userService.GetUserIdByTeacherId(teacherId);

            return new JsonResult(new
            {
                RequestId = requestId,
                TeacherUserId = teacherUserId
            });
          
        }

        [HttpGet]
        public async Task<IActionResult> All(string courseId)
        {
            bool isCourseApproved = await courseService.IsCourseApproved(courseId);
            if (!isCourseApproved)
            {
                TempData[ErrorMessage] = "Този курс не е одобрен.";
                return RedirectToAction("MyCourses", "Course");
            }

            bool isTeacher = await teacherService.IsTeacherAsync(User.GetId());

            if(!isTeacher)
            {
                TempData[ErrorMessage] = "Трябва да си учител за да имаш достъп";
                return RedirectToAction("Index", "Home");
            }

            bool isCourseValid = await courseService.IsCourseValid(courseId);

            if (!isCourseValid)
            {
                TempData[ErrorMessage] = "Този курс не съществува";
                return RedirectToAction("MyCourses", "Course");
            }

            var model = await courseService.GetCourseWithAllRequest(courseId);
            model.CourseId = courseId;

            if (model.Requests.Count == 0)
            {
                return View(model);
            }
            else
            {
                model.Requests = model.Requests.OrderByDescending(r => r.Status).ToList();
                
                return View(model);
            }
            
        }

       

        [HttpPost]
        public async Task<IActionResult> EditStatus(string requestId, string status)
        {
            var request = await requestService.GetRequestByIdAsync(requestId);

            string userId = User.GetId()!;

            bool isTeacher = await teacherService.IsTeacherAsync(userId);

            if(!isTeacher )
            {
                TempData[ErrorMessage] = "Трябва да сте учител, за да имате достъп.";
                return RedirectToAction("MyCourses", "Course");
            }

            if(request ==  null)
            {
                TempData[ErrorMessage] = "Тази заявка не съществува";
                return RedirectToAction("MyCourses", "Course");
            }

            if(status == "Accepted")
            {
                var teacherId = await teacherService.GetTeacherIdByUserId(userId);

                var studentId = await studentService.GetStudentIdByRequestId(requestId);

                var courseId = await courseService.GetCourseIdByRequestId(requestId);
               
                await courseService.AddStudentToCourse(studentId, courseId);

                bool resultAccepted = await requestService.EditStatus(status, requestId);

                return new JsonResult(new { IsEdited = resultAccepted, StudentUserId = userId });

            }

            bool resultRejected = await requestService.EditStatus(status, requestId);

            return new JsonResult(new { IsEdited = resultRejected, StudentUserId = userId });

        }

    }
}
