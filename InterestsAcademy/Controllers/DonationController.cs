using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Controllers
{
    public class DonationController : Controller
    {

        public async Task<IActionResult> Categories()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
