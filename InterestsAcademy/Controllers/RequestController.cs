using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Request;
using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class RequestController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;
        private readonly IRequestService requestService;
        public RequestController(ICourseService courseService, ITeacherService teacherService, IRequestService requestService, IStudentService studentService)
        {
            this.courseService = courseService;
            this.teacherService = teacherService;
            this.requestService = requestService;
            this.studentService = studentService;
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

            string courseName = await courseService.GetCourseNameById(courseId);

            return View("Create", courseName);

        }

        [HttpPost]
        [Route("Request/Create")]
        public async Task<IActionResult> Create(string courseName, string studentName, string studentEmail)
        {
            var teacherId = await teacherService.GetTeacherIdByCourseNameAsync(courseName);

            //bool isTeacher = await teacherService.IsTeacherAsync(teacherId);

            //if (!isTeacher)
            //{
            //    TempData[ErrorMessage] = "Този курс не съществува.";
            //    return RedirectToAction("Index", "Home");
            //}
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

            return new JsonResult(new
            {
                RequestId = requestId,
                teacherUserId = teacherId
            });
        }

    }
}
