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
        private readonly IStudentService studentService;
        private readonly IImageService imageService;


		public AccountController(IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager, IStudentService studentService, IImageService imageService)
		{
			this.userService = userService;
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.studentService = studentService;
			this.imageService = imageService;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(await userService.IsExistByEmail(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Този имейл вече е регистриран");
            }

            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            { 
             Name = model.Name,
             Email = model.Email,
             PhoneNumber = model.PhoneNumber,
             BirthDate = model.BirthDate,
             UserName = model.UserName,
             Gender = model.Gender,
             Address = model.Address,
             City = model.City,
             Country = model.Country,
             RegisteredOn = DateTime.Now
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if(result.Succeeded)
            {
                //ToDo: add role

                await studentService.CreateAsync(user.Id);

                if(model.ProfilePicture != null)
                {

					user.ProfilePictureUrl = await imageService.UploadImage(model.ProfilePicture, "projectImages", user);
					await userManager.UpdateAsync(user);
				}

                await signInManager.SignInAsync(user, isPersistent: false);
				TempData[SuccessMessage] = "Успешна регистрация.";

				return RedirectToAction("Index", "Home");
			}

            return View(model);
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

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
