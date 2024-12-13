using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            var model = await courseService.GetAllStudentCoursesCards(User.GetId());

            return View(model);
        }
    }
}
