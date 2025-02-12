using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using static InterestsAcademy.Common.ErrorMessages;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly ITeacherService teacherService;
        private readonly IUserService userService;

        public TeacherController(ITeacherService teacherService, IUserService userService)
        {
            this.teacherService = teacherService;
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> ApproveTeacher(string id)
        {
            bool isExist = await userService.IsExistsByIdAsync(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "Този учител не съществува.";
                return RedirectToAction("Index", "Home");
            }

            await userService.ChangeUserIsApprovedAsync(id);

            
            return RedirectToAction("Index", "Home");
            

        }
    }
}
