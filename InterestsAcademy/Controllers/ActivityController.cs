using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Controllers
{
    public class ActivityController : Controller
    {
        public async Task<IActionResult> All()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
