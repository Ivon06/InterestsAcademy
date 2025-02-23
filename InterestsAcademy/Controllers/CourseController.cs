using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;
        private readonly IRoomService roomService;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;

        public CourseController(ICourseService courseService, IRoomService roomService, ITeacherService teacherService, IStudentService studentService)
        {
            this.courseService = courseService;
            this.roomService = roomService;
            this.teacherService = teacherService;
            this.studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MyCourses([FromQuery] MyCoursesViewModel model)
        {
            string userId = User.GetId();

            bool isTeacher = await teacherService.IsTeacherAsync(userId);

            //var model = new MyCoursesViewModel();

            //IEnumerable<CourseCardViewModel> model = new List<CourseCardViewModel>();

            bool isStudent = await studentService.IsStudentAsync(userId);
            if (isTeacher)
            {
                string teacherId = await teacherService.GetTeacherIdByUserId(userId);
                model.Cards = await courseService.GetAllTeacherCourses(teacherId);
            }
            else if (isStudent)
            {
                string studentId = await studentService.GetStudentId(userId);
                model.Cards = await courseService.GetAllStudentCoursesCards(studentId);
            }


            if (!string.IsNullOrEmpty(model.SearchString))
            {

                string wildCard = $"{model.SearchString.ToLower()}";

                model.Cards = model.Cards
                    .Where(c => c.Name.ToLower().Contains(wildCard) || c.Description.ToLower().Contains(wildCard));
            }

            if (!string.IsNullOrEmpty(model.Category))
            {
                model.Cards = model.Cards
                    .Where(c => c.Category==model.Category);
            }

            model.Categories = new List<string>()
            {
               "Biology",
               "Physics",
               "Art",
               "It",
               "Sport",
               "Other"
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CourseQueryModel();

            //  model.Rooms = await roomService.GetAllRooms();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CourseQueryModel model)
        {
            var userId = User.GetId();
            bool isTeacher = await teacherService.IsTeacherAsync(userId);
            if (isTeacher == false)
            {
                TempData[ErrorMessage] = "Трябва да сте учител, за да добавите курс";
                return RedirectToAction("All");
            }

            var teacherId = await teacherService.GetTeacherIdByUserId(userId);
            var teacherCourses = await courseService.GetAllTeacherCourses(teacherId);

            if (teacherCourses.Select(c => c.Name).Contains(model.Name))
            {
                ModelState.AddModelError(nameof(model.Name), "Курс с това име вече съществува.");

            }

            model.TeacherId = teacherId;

            if (!ModelState.IsValid)
            {
                return View(model);
            }



            await courseService.AddCourse(model);

            TempData[SuccessMessage] = "Успешно добавен курс. Изчакайте администратора да го одобри.";

            return RedirectToAction("MyCources");
        }

        public async Task<IActionResult> All()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData[ErrorMessage] = "Трябва да се регистрирате, за да достъпите тази функция.";
                return RedirectToAction("Index", "Home");
            }

            var model = await courseService.GetAllCoursesCards();

            return View(model);
        }

        public async Task<IActionResult> Info(string id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string courseId)
        {
            var model = await courseService.GetCourseForEdit(courseId);

            model.Rooms = await roomService.GetAllRooms();

            return View(model);

        }
    }
}
