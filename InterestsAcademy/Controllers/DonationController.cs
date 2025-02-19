using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Donation;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class DonationController : Controller
    {
        private readonly IDonationService donationService;

        public DonationController(IDonationService donationService)
        {
            this.donationService = donationService;
        }

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
        public async Task<IActionResult> Donate(string id)
        {
            var model = await donationService.GetItemForDonate(id);
            return View("Create", model);
        }

        [HttpPost]
        public async Task<IActionResult> Donate(CreateDonationViewModel model)
        {

            if(!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                return View("Create",model);
            }

            await donationService.Donate(model);
            TempData[SuccessMessage] = "Успешно дарихте.";
            return RedirectToAction("Categories", "Donation", new { category = "All" });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
