using InterestsAcademy.Core.Models.Activity;
using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IActivityService
    {
        Task<List<Activity>> GetAllActivitiesByRoomId(int roomId);
        Task<List<Activity>> GetAllActivityByCourseId(int courseId);
        Task<ActivityViewModel?> GetActivityByIdAsync(string activityId);
        Task<List<ActivityViewModel>> GetAllCourseActivitiesForDayAsync(int days, string courseId);
        Task<List<ActivityViewModel>> GetAllTeacherActivitiesForDayAsync(int days, string teacherId);
        Task<List<ActivityViewModel>> GetAllRoomActivitiesForDayAsync(int days, string roomId);

        Task<bool> IsMeetingExistsAsync(DateTime start, DateTime end, string courseId, string roomId);
        Task<string> CreateAsync(ActivityQueryModel model);
        Task DeleteMeetingAsync(string meetingId);

        Task<DeleteActivityViewModel?> GetMeetingForDeleteAsync(string activityId);

        Task<bool> IsActivityInTeacherSchedule(string activityId, string teacherId);
        Task<int> GetAllActivitiesCount();
        Task<bool> IsActivityExistById(string activityId);
        Task<DetailsViewModel?> GetDetailsForMeetingAsync(string activityId);





    }
}
