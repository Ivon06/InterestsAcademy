using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Hubs;
using InterestsAcademy.Core.Models.Donation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class DonationController : Controller
    {
        private readonly IDonationService donationService;
        private readonly IHubContext<DonationHub> hubContext;

        public DonationController(IDonationService donationService, IHubContext<DonationHub> hubContext)
        {
            this.donationService = donationService;
            this.hubContext = hubContext;
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
        public async Task<IActionResult> CreateDonate(string id)
        {
            bool isValidItem = await donationService.IsItemValid(id);
            if (!isValidItem)
            {
                TempData[ErrorMessage] = "Този предмет не съществува.";
                return RedirectToAction("Categories", "Donation", new {category="All"});
            }

            var model = await donationService.GetItemForDonate(id);
            return View("Create", model);
        }

        
        [HttpPost]
        public async Task<IActionResult> Donate(string id, int quantity, string name, string email)
        {
            if (!ModelState.IsValid)
            {
                var model = await donationService.GetItemForDonate(id);
                TempData["ErrorMessage"] = "Неправилни данни.";
                return View("Create", model);
            }

            var model2 = await donationService.GetItemForDonate(id);

            model2.Quantity = quantity;
            model2.GiverName = name;
            model2.GiverEmail = email;

            await donationService.Donate(model2);

            TempData["SuccessMessage"] = "Успешно дарихте.";

            var item = await donationService.GetItemForDonate(id);

            return new JsonResult(new { id = item.Id, amount = item.NeededQuantity });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
