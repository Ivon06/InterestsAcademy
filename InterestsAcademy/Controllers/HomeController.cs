using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Email;
using InterestsAcademy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IEmailService emailService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService )
        {
            _logger = logger;
            this.emailService = emailService;
        }

        public IActionResult Index()
		{
            if (User.IsInRole("Admin"))
                //check if works
            {
                return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
            }
            return View();
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
