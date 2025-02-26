using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Core.Models.Profile;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService profileService;
        private readonly ICourseService courseService;
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;

        public ProfileController(IProfileService profileService, IUserService userService, IStudentService studentService, ITeacherService teacherService, ICourseService courseService)
        {
            this.profileService = profileService;
            this.userService = userService;
            this.studentService = studentService;
            this.teacherService = teacherService;
            this.courseService = courseService; 
        }
        public async Task<IActionResult> TeacherProfile(string userId)
        {
            bool isExists = await userService.IsExistsByIdAsync(userId);
            if (!isExists)
            {
                TempData[ErrorMessage] = "Този потребител не съществува";
                return RedirectToAction("Index", "Home");
            }

            string teacherId = await teacherService.GetTeacherIdByUserId(userId);

            TeacherProfileCourseViewModel model = await courseService.GetTeacherProfileWithCoursesAsync(teacherId);

            return View("TeacherProfile", model);
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
           


        }

        public async Task<IActionResult> Edit(string id)
        {
            bool isExists = await userService.IsExistsByIdAsync(id);
            if (!isExists)
            {
                TempData[ErrorMessage] = "Този потребител не съществува";
                return RedirectToAction("Index", "Home");
            }
            if (User.GetId() != id)
            {
                TempData[ErrorMessage] = "Не може да редактирате този профил.";
                return RedirectToAction("Index", "Home");
            }

            var model = await profileService.GetProfileForEditAsync(id);
            model.Id = id;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProfileViewModel model)
        {
            bool isExists = await userService.IsExistsByIdAsync(model.Id);
            if (!isExists)
            {
                TempData[ErrorMessage] = "Този потребител не съществува";
                return RedirectToAction("Index", "Home");
            }
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Неправилни данни";
                return View(model);
            }

            await profileService.EditProfileAsync(model);

            return RedirectToAction("MyProfile", "Profile", new { userId = model.Id });

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
