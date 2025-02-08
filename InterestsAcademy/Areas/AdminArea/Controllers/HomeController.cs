using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await userService.GetAllUsersAsync();
            return View(model);
        }
    }
}
