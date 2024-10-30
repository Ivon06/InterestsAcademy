using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Account;
using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userService.GetByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    TempData[SuccessMessage] = "Успешно влизане";
                    return RedirectToAction("Index", "Home");

                }
            }

            ModelState.AddModelError(nameof(model.Email), "Invalid login");

            return View(model);
        }
    }
}
