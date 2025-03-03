using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.PrivateChat;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Identity;
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
        private readonly IUserService userService;
        private readonly IGroupService groupService;
        private readonly UserManager<User> userManager;

        public PrivateChatController(IPrivateChatService privateChatService, ITeacherService teacherService, IStudentService studentService, ICourseService courseService, IUserService userService, IGroupService groupService, UserManager<User> userManager)
        {
            this.privateChatService = privateChatService;
            this.teacherService = teacherService;
            this.studentService = studentService;
            this.courseService = courseService;
            this.userService = userService;
            this.groupService = groupService;
            this.userManager = userManager;
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

        public async Task<IActionResult> Chat(string toUsername, string group)
        {
            string userId = User.GetId()!;
            var toUserId = await userService.GetUserIdByUsernameAsync(toUsername);

            if (toUserId == null)
            {
                TempData[ErrorMessage] = "Непрвилен потребител";
                return RedirectToAction("UsersToChat");
            }

            var groupId = await groupService.GetGroupBetweenUsersAsync(userId, toUserId);
            string? groupName = await groupService.GetGroupNameByIdAsync(groupId!);

            var messages = await privateChatService.ExtractAllMessagesAsync(groupName == null ? group : groupName);


            var model = new PrivateChatViewModel()
            {
                FromUser = await userManager.GetUserAsync(this.HttpContext.User),
                ToUser = await userManager.FindByIdAsync(toUserId),
                ChatMessages = messages,
                Group = groupName == null ? group : groupName,

            };

            return View(model);
        }

        [HttpPost]
        [Route("/PrivateChat/SendMessageWithFiles")]
        public async Task<IActionResult> SendMessageWithFiles(IList<IFormFile> files, string group, string toUsername,
            string fromUsername, string message)
        {
            var currentUser = await userManager.GetUserAsync(this.User);
            bool isAbleToChat = await privateChatService.IsAbleToChatAsync(toUsername, group, currentUser);

            if (!isAbleToChat)
            {
                TempData[ErrorMessage] = "Потребителя не може да получава съобщения";
                return RedirectToAction("UsersToChat");
            }


            var haveFiles = await privateChatService.SendMessageWitFilesToUser(files, group, toUsername, fromUsername, message);


            return new JsonResult(new { haveFiles });
        }

        [HttpGet]
        [Route("/PrivateChat/LoadMoreMessages")]
        public async Task<IActionResult> LoadMoreMessages(string username, string group, int? messagesSkipCount)
        {
            var currentUser = await this.userManager.GetUserAsync(this.User);
            bool isAbleToChat = await privateChatService.IsAbleToChatAsync(username, group, currentUser);

            if (!isAbleToChat)
            {
                TempData[ErrorMessage] = "Потребителя не може да пoлучава съобщения";
                return RedirectToAction("UsersToChat");
            }

            if (messagesSkipCount == null)
            {
                messagesSkipCount = 0;
            }

            ICollection<LoadMoreMessagesViewModel> data =
                await privateChatService.LoadMoreMessagesAsync(group, (int)messagesSkipCount, currentUser);


            return new JsonResult(data);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
