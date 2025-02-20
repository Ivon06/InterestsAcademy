using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Donation;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class DonationController : BaseController
    {
        private readonly IDonationService donationService;

        public DonationController(IDonationService donationService)
        {
            this.donationService = donationService;
        }

        [HttpGet]
        public async Task<IActionResult> Categories(string category)
        {
            if (category == "All")
            {
                var model = await donationService.GetAll();
                return View(model);
            }
            else
            {
                var model = await donationService.GetAllByCategory(category);
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if(!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да сте администратор, за да добавите дарение.";
                return RedirectToAction("Index", "Home");
            }

            var model = new AddDonationQueryModel();

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

        [HttpPost]
        public async Task<IActionResult> Add(AddDonationQueryModel model)
        {
            if (!ModelState.IsValid)
            {
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

            if (!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да сте администратор, за да добавите дарение.";
                return RedirectToAction("Index", "Home");
            }

            await donationService.Add(model);
            TempData[SuccessMessage] = "Успешно добавихте дарение.";
            return RedirectToAction("Categories", "Donation", new {category="All"});
        }

        public async Task<IActionResult> All(string id)
        {
            if (!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да сте администратор, за да видите тази страница.";
                return RedirectToAction("Index", "Home");
            }

            var model = await donationService.AdminDonations(id);

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
