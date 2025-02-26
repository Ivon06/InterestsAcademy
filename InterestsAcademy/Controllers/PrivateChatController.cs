using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.PrivateChat;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class PrivateChatController : Controller
    {

        private readonly IPrivateChatService privateChatService;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;
        private readonly ICourseService courseService;

        public PrivateChatController(IPrivateChatService privateChatService, ITeacherService teacherService, IStudentService studentService, ICourseService courseService)
        {
            this.privateChatService = privateChatService;
            this.teacherService = teacherService;
            this.studentService = studentService;
            this.courseService = courseService;
        }

        public async Task<IActionResult> UsersToChat()
        {
            string userId = User.GetId()!;
           
            bool isTeacher = await teacherService.IsTeacherAsync(userId);
            bool isStudent = await studentService.IsStudentAsync(userId);
            if (isTeacher)
            {
                var teacherId = await teacherService.GetTeacherIdByUserId(userId);
                var coursesIds = await courseService.GetAllCoursesIdsByTeacherId(teacherId);
                var users = await privateChatService.GetUsersToChatAsync(coursesIds, userId);
                //var companies = await privateChatService.GetTeacherCompaniesToChatAsync(userId);

               

                users = users
                    .OrderByDescending(u => u.LastMessageToUser != null)
                    .ThenByDescending(u => u.LastMessageToUser?.SendedOn)
                    .ToList();

                return View(users);
            }
            else if (isStudent)
            {
                string studentId = await studentService.GetStudentId(userId);
                var classId = await courseService.GetAllCoursesIdsByStudentId(studentId);

                var users = await privateChatService.GetUsersToChatAsync(classId!, userId);


                var studentTeacher = await privateChatService.GetTeacherUsersToChatAsync(classId!, userId);


                if (studentTeacher != null)
                {
                    users.AddRange(studentTeacher);
                }
                

                if (users.Count > 0)
                {
                    users = users
                    .OrderByDescending(u => u.LastMessageToUser != null)
                    .ThenByDescending(u => u.LastMessageToUser?.SendedOn)
                    .ToList();
                }
                else
                {
                    users = new List<UsersToChatViewModel>();
                }



                return View(users);

            }
            else
            {
                TempData[ErrorMessage] = "Неправилен потребител";
                return RedirectToAction("Index", "Home");
            }

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
