using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.ErrorMessages;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> AcceptRequest(string id)
        {
            bool isExists = await userService.IsExistsByIdAsync(id);
            if (!isExists)
            {
                TempData[ErrorMessage] = "Този потребител не съществува.";
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }

            if (!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да си администратор, за да имаш достъп.";
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }

            await userService.ChangeUserIsApprovedAsync(id);


            return RedirectToAction("Index", "Home", new { Area = "Admin" });


        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            bool isValidUser = await userService.IsExistsByIdAsync(userId);

            if (!isValidUser)
            {
                TempData[ErrorMessage] = "Този потребител не съществува.";
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }

            await userService.DeleteUser(userId);

            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }
    }
}
