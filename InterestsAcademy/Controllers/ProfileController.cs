using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService profileService;
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;

        public ProfileController(IProfileService profileService, IUserService userService, IStudentService studentService, ITeacherService teacherService)
        {
            this.profileService = profileService;
            this.userService = userService;
            this.studentService = studentService;
            this.teacherService = teacherService;
        }

        public async Task<IActionResult> MyProfile(string userId)
        {
            bool isExists = await userService.IsExistsByIdAsync(userId);
            if (!isExists)
            {
                TempData[ErrorMessage] = "Този потребител не съществува";
                return RedirectToAction("Index", "Home");
            }

            var model = await profileService.GetUserProfileAsync(userId);

            return View("Profile",model);

            //bool isStudent = await studentService.IsStudentAsync(userId);
            //if (isStudent)
            //{
            //    string? studentId = await studentService.GetStudentId(userId);
            //    var studentModel = await profileService.GetStudentProfileAsync(studentId!);
            //    return View("Student", studentModel);
            //}

            //bool isTeacher = await teacherService.IsTeacherAsync(userId);
            //if (isTeacher)
            //{
            //    var teacherId = await teacherService.GetTeacherIdByUserId(userId);
            //    var teacherModel = await profileService.GetTeacherProfileAsync(teacherId!);

            //    return View("Teacher", teacherModel);
            //}
           


            TempData[InformationMessage] = "Този потребител не е нито учител нито ученик";
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
