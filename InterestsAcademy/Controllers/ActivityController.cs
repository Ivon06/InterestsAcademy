using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Activity;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
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
        private readonly IUserService userService;
        private readonly IStudentService studentService;

        public ActivityController(IActivityService activityService, ICourseService courseService, IRoomService roomService, ITeacherService teacherService, IUserService userService, IStudentService studentService)
        {
            this.activityService = activityService;
            this.courseService = courseService;
            this.roomService = roomService;
            this.teacherService = teacherService;
            this.userService = userService;
            this.studentService = studentService;
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
                        model.CourseView = true;
                        model.RoomView = false;
                        model.TeacherView = false;
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
                    bool isValid = await teacherService.IsTeacherIdValidAsync(groupId);

                    if (isValid)
                    {

                        model.CourseView = false;
                        model.RoomView = false;
                        model.TeacherView = true;

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
                else if (isCourse == false && isTeacher == false)
                {
                    bool isValid = await roomService.IsRoomValid(groupId);



                    if (isValid)
                    {
                        model.CourseView = false;
                        model.RoomView = true;
                        model.TeacherView = false;
                        model.RoomId = groupId;
                        model.AllRoomCourses = await courseService.GetAllCoursesByRoomId(groupId);

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

        [HttpPost]
        public async Task<IActionResult> Create(string courseId, string topic, DateTime start, DateTime end)
        {
            string userId = User.GetId()!;

            bool isTeacher = await teacherService.IsTeacherAsync(userId);

            if (!isTeacher) 
            {
                TempData[ErrorMessage] = "Трябва да сте учител, за да добавите събитие към курса.";
                return RedirectToAction("All", "Meeting");
            }

            bool isCourseValid = await courseService.IsCourseValid(courseId);

            if (!isCourseValid)
            {
                TempData[ErrorMessage] = "Този курс не съществува.";
                return RedirectToAction("All", "Meeting");
            }

            string teacherId = await teacherService.GetTeacherIdByUserId(userId);

            bool isCourseOfTeacher = await courseService.IsCourseValidForTeacher(courseId, teacherId);

            if (!isCourseOfTeacher)
            {
                TempData[ErrorMessage] = "Тозu курс се води от друг учител.";
                return RedirectToAction("All", "Meeting");
            }

            string roomId = await roomService.GetRoomIdByCourseId(courseId);

            bool isExists = await activityService.IsMeetingExistsAsync(start, end, courseId,roomId);
            if (isExists)
            {
                return new JsonResult(new { isExists, ClassIdNull = false });
            }

            if (courseId == null)
            {
                return new JsonResult(new { ClassIdNull = true });
            }

            try
            {
                string? teacherUserId = await userService.GetUserIdByTeacherId(teacherId);
                //courseid
                //string? companyId = await companyService.GetCompanyIdAsync(userId);

                //bool isExistsInCompany = await activityService.IsMeetingExistsInCompanyAsync(start, end, companyId!, classId);
                //if (isExistsInCompany)
                //{
                //    return new JsonResult(new { isExists = true, ClassIdNull = false });
                //}


                List<string> receiversIds = await studentService.GetAllStudentsUsersIdsByCourseId(courseId);

                receiversIds.Add(teacherUserId!);

                List<string> teachersIds = await teacherService.GetAllTeacherUsersIdByRoomId(roomId);

                receiversIds.AddRange(teachersIds);

                ActivityQueryModel model = new ActivityQueryModel()
                {
                    Topic = topic,
                    End = end,
                    Start = start,
                    CourseId = courseId,
                    TeacherId = teacherId
                };

                if (start >= end)
                {
                    TempData[ErrorMessage] = "Неправилна начална дата";
                    return this.RedirectToAction("All", "Meeting");

                }

                string activityId = await activityService.CreateAsync(model);

                TempData[SuccessMessage] = "Успешно добавена дейност";
                return new JsonResult(new { MeetingId = activityId, ReceiversIds = receiversIds, isExists = false, ClassIdNull = false });



            }
            catch (Exception ex)
            {
               TempData[ErrorMessage] = ex.Message;
                return RedirectToAction("Index", "Home");
            }


        }


        [HttpGet]
        [Route("/Meeting/Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            string userId = User.GetId()!;

            bool isTeacher = await teacherService.IsTeacherAsync(userId);
            if (!isTeacher)
            {
                TempData[ErrorMessage] = "Ти трябва да бъдеш учител, за да изтриваш срещи";
                return this.RedirectToAction("All");
            }
            string? teacherId = await teacherService.GetTeacherIdByUserId(userId);
            bool isInTeacherSchedule = await activityService.IsActivityInTeacherSchedule(id!, teacherId);

            if (!isInTeacherSchedule)
            {
                TempData[ErrorMessage] = "Тази среща не е в твоя график";
                return this.RedirectToAction("All");
            }

            var model = await activityService.GetMeetingForDeleteAsync(id);

            if (model == null)
            {
                TempData[ErrorMessage] = "Тази среща не съществува";
                return this.RedirectToAction("All");
            }

            return View(model);
        }

        [HttpPost]
        [Route("/Meeting/Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id, DeleteActivityViewModel model)
        {
            string userId = User.GetId()!;

            bool isTeacher = await teacherService.IsTeacherAsync(userId);
            if (!isTeacher)
            {
                TempData[ErrorMessage] = "Ти трябва да бъдеш учител, за да изтриваш срещи";
                return this.RedirectToAction("All");
            }
            string? companyId = await teacherService.GetTeacherIdByUserId(userId);
            bool isInCompanySchedule = await activityService.IsActivityInTeacherSchedule(companyId!, id);

            if (!isInCompanySchedule)
            {
                TempData[ErrorMessage] = "Тази среща не е в твоя график";
                return this.RedirectToAction("All");
            }
            string? teacherId = await teacherService.GetTeacherIdByUserId(userId);

            string? teacherUserId = await userService.GetUserIdByTeacherId(teacherId);

            string courseId = model.CourseId;
            

            List<string> receiversIds = await studentService.GetAllStudentsUsersIdsByCourseId(courseId);

            receiversIds.Add(teacherUserId!);

            string roomId = await roomService.GetRoomIdByCourseId(courseId);

            List<string> teachersIds = await teacherService.GetAllTeacherUsersIdByRoomId(roomId);

            receiversIds.AddRange(teachersIds);

            await activityService.DeleteMeetingAsync(id);

            TempData[SuccessMessage] = "Успешно изтрита среща";

            return new JsonResult(new { ReceiversIds = receiversIds, activityId = id });


        }

        [HttpGet]
        [Route("/Meeting/Details/{id}")]
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            string? userId = User.GetId();
            bool isTeacher = await teacherService.IsTeacherAsync(userId!);
            bool isStudent = await studentService.IsStudentAsync(userId!);



            bool isMeetingExists = await activityService.IsActivityExistById(id!);
            if (!isMeetingExists)
            {
                TempData[ErrorMessage] = "Тази среща не съществува";
                return new JsonResult(new { isExists = false });
            }

            //bool isMeetingHaveRoom = await activityService.IsMeetingAlreadyHaveRoomAsync(id);
            if (isTeacher)
            {
                string? teacherId = await teacherService.GetTeacherIdByUserId(userId!);
                bool isInCompanySchedule = await activityService.IsActivityInTeacherSchedule(id, teacherId!);
                if (!isInCompanySchedule)
                {
                    TempData[ErrorMessage] = "Тази среща не е в твоя график";
                    return new JsonResult(new { isExists = false });
                }

                var activity = await activityService.GetDetailsForMeetingAsync(id);

                return new JsonResult(new { activity, isExists = true, isTeacher});


            }
            else if ( isStudent)
            {

                var activity = await activityService.GetDetailsForMeetingAsync(id);

                return new JsonResult(new { activity, isExists = true,  isTeacher=false });
            }

            return new JsonResult(new { isExists = isMeetingExists });

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
