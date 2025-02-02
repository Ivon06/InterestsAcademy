using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Activity;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService activityService;
        private readonly ICourseService courseService;
        private readonly IRoomService roomService;
        private readonly ITeacherService teacherService;

        public ActivityController(IActivityService activityService, ICourseService courseService, IRoomService roomService, ITeacherService teacherService)
        {
            this.activityService = activityService;
            this.courseService = courseService;
            this.roomService = roomService;
            this.teacherService = teacherService;
        }

        public async Task<IActionResult> All(int days, string groupId, bool isTeacher, bool isCourse)
        {
            AllActivityViewModel model = new AllActivityViewModel();
            model.Days = days;
            model.Month = DateTime.Now.AddDays(days).ToString("MMMM", CultureInfo.InvariantCulture);
            string userId = User.GetId()!;
            if (string.IsNullOrEmpty(userId))
            {
                TempData[ErrorMessage] = "Неправилен потребител";
                return RedirectToAction("Login", "Account");
            }
            try
            {
                if (isCourse == true && isTeacher == false)
                {
                    bool isValid = await courseService.IsCourseValid(groupId);

                    if (isValid)
                    {
                        model.CourseId = groupId;
                        model.DayNow = await activityService.GetAllCourseActivitiesForDayAsync(days, groupId);
                        model.DayTomorrow = await activityService.GetAllCourseActivitiesForDayAsync(days + 1, groupId);
                        model.Day2 = await activityService.GetAllCourseActivitiesForDayAsync(days + 2, groupId);
                        model.Day3 = await activityService.GetAllCourseActivitiesForDayAsync(days + 3, groupId);
                        model.Day4 = await activityService.GetAllCourseActivitiesForDayAsync(days + 4, groupId);
                        model.Day5 = await activityService.GetAllCourseActivitiesForDayAsync(days + 5, groupId);
                        model.Day6 = await activityService.GetAllCourseActivitiesForDayAsync(days + 6, groupId);
                    }
                    else
                    {
                        TempData[ErrorMessage] = "Неправилен курс";
                        return RedirectToAction("Index", "Home");
                    }
                }
                else if (isCourse == false && isTeacher == true)
                {
                    bool isValid = await teacherService.IsTeacherAsync(groupId);

                    if (isValid)
                    {



                        model.TeacherId = groupId;
                        model.DayNow = await activityService.GetAllTeacherActivitiesForDayAsync(days, groupId);
                        model.DayTomorrow = await activityService.GetAllTeacherActivitiesForDayAsync(days + 1, groupId);
                        model.Day2 = await activityService.GetAllTeacherActivitiesForDayAsync(days + 2, groupId);
                        model.Day3 = await activityService.GetAllTeacherActivitiesForDayAsync(days + 3, groupId);
                        model.Day4 = await activityService.GetAllTeacherActivitiesForDayAsync(days + 4, groupId);
                        model.Day5 = await activityService.GetAllTeacherActivitiesForDayAsync(days + 5, groupId);
                        model.Day6 = await activityService.GetAllTeacherActivitiesForDayAsync(days + 6, groupId);
                    }
                    else
                    {
                        TempData[ErrorMessage] = "Неправилен учител";
                        return RedirectToAction("Index", "Home");
                    }

                }
                else
                {
                    bool isValid = await roomService.IsRoomValid(groupId);

                    if (isValid)
                    {
                        model.RoomId = groupId;
                        model.DayNow = await activityService.GetAllRoomActivitiesForDayAsync(days, groupId);
                        model.DayTomorrow = await activityService.GetAllRoomActivitiesForDayAsync(days + 1, groupId);
                        model.Day2 = await activityService.GetAllRoomActivitiesForDayAsync(days + 2, groupId);
                        model.Day3 = await activityService.GetAllRoomActivitiesForDayAsync(days + 3, groupId);
                        model.Day4 = await activityService.GetAllRoomActivitiesForDayAsync(days + 4, groupId);
                        model.Day5 = await activityService.GetAllRoomActivitiesForDayAsync(days + 5, groupId);
                        model.Day6 = await activityService.GetAllRoomActivitiesForDayAsync(days + 6, groupId);
                    }
                    else
                    {
                        TempData[ErrorMessage] = "Неправилна стая";
                        return RedirectToAction("Index", "Home");
                    }
                }

            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;
                return RedirectToAction("Index", "Home");
            }

            return View(model);



        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
