using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Email;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IEmailService emailService;
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly IActivityService activityService;
        private readonly ICourseService courseService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService,IUserService userService ,IStudentService studentService, IActivityService activityService, ICourseService course)
        {
            _logger = logger;
            this.emailService = emailService;
            this.userService = userService;
            this.studentService = studentService;
            this.activityService = activityService;
            this.courseService = course;
        }

        public async Task<IActionResult> Index()
		{
            if (User.IsInRole("Admin"))
                //check if works
            {
                return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
            }
            var model = await userService.GetAllUsersAsync();
            model.StudentsCount = await studentService.GetAllStudentsCount();
            model.ActivitiesCount = await activityService.GetAllActivitiesCount();
            var courses = await courseService.GetAllCoursesCards();
            model.CoursesCount = courses.ToList().Count;

            return View(model);
		}
        public IActionResult ProjectandConcept()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            SendMessageQueryModel message = new SendMessageQueryModel();
            return View(message);
        }

        [HttpPost]
        public async Task<IActionResult> Contact(SendMessageQueryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await emailService.SendEmailAsync(model);

            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;
                return View(model);
            }

            TempData[SuccessMessage] = "Успешно изпратен имейл";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Project()
        {
            return View();
        }
        public IActionResult Privacy()
		{
			return View();
		}

        public IActionResult Error404()
        {
            string errorMessage = TempData["ErrorMessage"]?.ToString() ?? "An unexpected error occurred.";

            ViewData["ErrorMessage"] = errorMessage;

            return View();
        }

        public IActionResult Error500()
        {
            string errorMessage = TempData["ErrorMessage"]?.ToString() ?? "An unexpected error occurred.";

            ViewData["ErrorMessage"] = errorMessage;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
