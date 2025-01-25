using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
