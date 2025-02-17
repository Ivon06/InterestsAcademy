using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            return View();
        }
    }
}
