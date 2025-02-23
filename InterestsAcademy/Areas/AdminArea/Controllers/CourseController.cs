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
            if (!User.Identity.IsAuthenticated )
            {
                TempData[ErrorMessage] = "Трябва да се регистрирате, за да достъпите тази функция.";
                return RedirectToAction("Index", "Home");
            }

            

            var model = await courseService.GetAllCoursesAdminCards();

            return View(model);
        }

        public async Task<IActionResult> Info(string id)
        {
            bool isValidCourse = await courseService.IsCourseValid(id);
            if (!isValidCourse)
            {
                TempData[ErrorMessage] = "Този курс не съществува";
                return RedirectToAction("All", "Course");
            }
            var model = await courseService.GetCourseForAdmin(id);
            return View(model);
        }

        [HttpGet]
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
                return RedirectToAction("Info", "Course", new {id=model.Id});


            }
            else
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SelectRoom (string courseId, string roomId)
        {
            bool isValidCourse = await courseService.IsCourseValid(courseId);

            if (!isValidCourse)
            {
                TempData[ErrorMessage] = "Този курс не съществува.";
                return RedirectToAction("All", "Course");
            }

            bool isCourseApproved = await courseService.IsCourseApproved(courseId);

            if (!isCourseApproved)
            {
                TempData[ErrorMessage] = "Този курс не е одобрен.";
                return RedirectToAction("All", "Course");
            }

            if(roomId == null)
            {
                TempData[ErrorMessage] = "Не е избрана стая.";
                return RedirectToAction("Info", "Course", new {id=courseId});
            }

            await courseService.SetRoomForCourse(roomId, courseId);
            await courseService.MakeCourseActive(courseId);

            TempData[SuccessMessage] = "Успешно зададохте стая за курса.";

            return RedirectToAction("Info", "Course", new { id = courseId, Area = "AdminArea"});
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCourse(string courseId)
        {
            bool isCourseValid = await courseService.IsCourseValid(courseId);

            if (!isCourseValid)
            {
                TempData[ErrorMessage] = "Този курс не съществува.";
                return RedirectToAction("Index", "Home");
            }

            var model = await courseService.GetCourseForDelete(courseId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteCourseQueryModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                 return View("DeleteCourse",model);
            }

            if(!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да сте админ, за да изтриете курс.";
                return RedirectToAction("Index", "Home"); 
            }

            await courseService.DeleteCourse(model.Id);

            TempData[SuccessMessage] = "Успешно изтрит курс.";
            return RedirectToAction("All", "Course", new {Area="AdminArea"});

        }
        public IActionResult Index()
        {
            return RedirectToAction("All");
        }
    }
}
