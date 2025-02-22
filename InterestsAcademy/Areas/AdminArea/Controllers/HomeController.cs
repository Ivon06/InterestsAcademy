using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly IActivityService activityService;
        private readonly ICourseService courseService;

        public HomeController(IUserService userService, IStudentService studentService, IActivityService activityService, ICourseService courseService)
        {
            this.userService = userService;
            this.studentService = studentService;
            this.activityService = activityService;
            this.courseService = courseService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await userService.GetAllUsersAsync();
            model.StudentsCount = await studentService.GetAllStudentsCount();
            model.ActivitiesCount = await activityService.GetAllActivitiesCount();
            var courses = await courseService.GetAllCoursesCards();
            model.CoursesCount = courses.ToList().Count;

            return View(model);
        }
    }
}
