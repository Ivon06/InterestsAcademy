using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;
        private readonly IRoomService roomService;
        private readonly ITeacherService teacherService;

        public CourseController(ICourseService courseService, IRoomService roomService, ITeacherService teacherService)
        {
            this.courseService = courseService;
            this.roomService = roomService;
            this.teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            bool isTeacher = await teacherService.IsTeacherAsync(User.GetId());
            IEnumerable<CourseCardViewModel> model = new List<CourseCardViewModel>();
            if (isTeacher)
            {
                string teacherId = await teacherService.GetTeacherIdByUserId(User.GetId());
                model = await courseService.GetAllTeacherCourses(teacherId);
            }
            else/*Add isStudentCheck*/
            {
                model = await courseService.GetAllStudentCoursesCards(User.GetId());
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CourseQueryModel();

            model.Rooms = await roomService.GetAllRooms();

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

            var teacherId = await teacherService.GetTeacherIdByUserId(User.GetId());
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

            TempData[SuccessMessage] = "Успешно добавен курс";

            return RedirectToAction("All");
        }
    }
}
