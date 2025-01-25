using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
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

        public async Task<IActionResult> Accept(string courseId)
        {
            bool isValidCourse = await courseService.IsCourseValid(courseId);

            if (!isValidCourse)
            {
                TempData[ErrorMessage] = "Няма заявка за този курс.";
                return RedirectToAction("Index", "Home");
            }

            bool isCourseApproved = await courseService.IsCourseApproved(courseId);

            if (isCourseApproved)
            {
                TempData[ErrorMessage] = "Този курс вече е одобрен.";
                return RedirectToAction("Index", "Home");
            }

            var model = await courseService.GetCourseForEdit(courseId);

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Accept(EditCourseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                return View(model);
            }

            var result = await courseService.ApproveCourse(model);

            if(result)
            {
                TempData[SuccessMessage] = "Курсът е одобрен успешно.";
                return RedirectToAction("All", "Course");


            }
            else
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                return View(model);
            }
        }
        public IActionResult Index()
        {
            return RedirectToAction("All");
        }
    }
}
