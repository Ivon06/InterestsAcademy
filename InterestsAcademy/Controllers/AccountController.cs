using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Account;
using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ITeacherService teacherService;


        public AccountController(IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager, IStudentService studentService, IImageService imageService, ITeacherService teacherService)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.studentService = studentService;
            this.imageService = imageService;
            this.teacherService = teacherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            RegisterViewModel model = new RegisterViewModel();

            model.Roles = await userService.GetRolesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (await userService.IsExistByEmail(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Този имейл вече е регистриран");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            User user;

            if (await userService.GetRoleNameAsync(model.RoleId) == "Teacher")
            {
                user = new User()
                {
                    Name = model.Name,
                    Email = model.Email,
                    UserName = model.UserName,
                    RegisteredOn = DateTime.Now,
                    IsApproved = false
                };
            }
            else
            {
                user = new User()
                {
                    Name = model.Name,
                    Email = model.Email,
                    UserName = model.UserName,
                    RegisteredOn = DateTime.Now
                };
            }

           

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {

               

                if (model.ProfilePicture != null)
                {

                    user.ProfilePictureUrl = await imageService.UploadImage(model.ProfilePicture, "projectImages", user);
                    await userManager.UpdateAsync(user);
                }

                if (await userService.GetRoleNameAsync(model.RoleId) == "Teacher")
                {
                    await userManager.AddToRoleAsync(user, "Teacher");
                    await teacherService.CreateAsync(user.Id);

                    TempData[SuccessMessage] = "Изчакай одобрение от администратор.";
                }
                else
                {
                    await studentService.CreateAsync(user.Id);

                    await userManager.AddToRoleAsync(user, "Student");

                    await studentService.CreateAsync(user.Id);

                    await signInManager.SignInAsync(user, isPersistent: false);

                    TempData[SuccessMessage] = "Успешна регистрация.";
                }

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
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

            if (user != null && user.IsActive && user.IsApproved)
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
