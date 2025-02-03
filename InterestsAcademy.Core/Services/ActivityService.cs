using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Activity;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IRepository repo;

        public ActivityService(IRepository repo)
        {
            this.repo = repo;
        }

        public Task<List<Activity>> GetAllActivitiesByRoomId(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Activity>> GetAllActivityByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ActivityViewModel>> GetAllCourseActivitiesForDayAsync(int days, string courseId)
        {
            var activities = await repo.GetAll<Activity>()
                .Include(m => m.Course)
                .OrderBy(m => m.Start)
                .Where(m => m.Start.DayOfYear == DateTime.Today.AddDays(days).DayOfYear &&
                m.Start.Year == DateTime.Today.AddDays(days).Year && m.CourseId == courseId)
                .Select(m => new ActivityViewModel()
                {
                    Id = m.Id,
                    Topic = m.Topic,
                    Day = m.Start.DayOfWeek.ToString().Substring(0, 3),
                    Date = m.Start.Day,
                    StartHour = m.Start.ToString("H:mm"),
                    EndHour = m.End.ToString("H:mm"),
                    CourseId = m.CourseId,
                    RoomId = m.Course.RoomId

                })
                .ToListAsync();

            if (activities.Count == 0)
            {
                activities.Add(new ActivityViewModel()
                {
                    Day = DateTime.Today.AddDays(days).DayOfWeek.ToString().Substring(0, 3),
                    Date = DateTime.Today.AddDays(days).Day
                });
            }

            return activities;

        }

        public async Task<List<ActivityViewModel>> GetAllTeacherActivitiesForDayAsync(int days, string teacherId)
        {
            var activities = await repo.GetAll<Activity>()
                .Include(m => m.Course)
                .OrderBy(m => m.Start)
                .Where(m => m.Start.DayOfYear == DateTime.Today.AddDays(days).DayOfYear &&
                m.Start.Year == DateTime.Today.AddDays(days).Year && m.CourseId == teacherId)
                .Select(m => new ActivityViewModel()
                {
                    Id = m.Id,
                    Topic = m.Topic,
                    Day = m.Start.DayOfWeek.ToString().Substring(0, 3),
                    Date = m.Start.Day,
                    StartHour = m.Start.ToString("H:mm"),
                    EndHour = m.End.ToString("H:mm"),
                    CourseId = m.CourseId,
                    RoomId = m.Course.RoomId

                })
                .ToListAsync();

            if (activities.Count == 0)
            {
                activities.Add(new ActivityViewModel()
                {
                    Day = DateTime.Today.AddDays(days).DayOfWeek.ToString().Substring(0, 3),
                    Date = DateTime.Today.AddDays(days).Day
                });
            }

            return activities;

        }

        public async Task<List<ActivityViewModel>> GetAllRoomActivitiesForDayAsync(int days, string roomId)
        {
            var activities = await repo.GetAll<Activity>()
                .Include(m => m.Course)
                .OrderBy(m => m.Start)
                .Where(m => m.Start.DayOfYear == DateTime.Today.AddDays(days).DayOfYear &&
                m.Start.Year == DateTime.Today.AddDays(days).Year && m.CourseId == roomId)
                .Select(m => new ActivityViewModel()
                {
                    Id = m.Id,
                    Topic = m.Topic,
                    Day = m.Start.DayOfWeek.ToString().Substring(0, 3),
                    Date = m.Start.Day,
                    StartHour = m.Start.ToString("H:mm"),
                    EndHour = m.End.ToString("H:mm"),
                    CourseId = m.CourseId,
                    RoomId = m.Course.RoomId

                })
                .ToListAsync();

            if (activities.Count == 0)
            {
                activities.Add(new ActivityViewModel()
                {
                    Day = DateTime.Today.AddDays(days).DayOfWeek.ToString().Substring(0, 3),
                    Date = DateTime.Today.AddDays(days).Day
                });
            }

            return activities;

        }


        public async Task<ActivityViewModel?> GetActivityByIdAsync(string activityId)
        {
            var meeting = await repo.GetAll<Activity>()
                .Include(m => m.Course)
                .Where(m => m.Id == activityId)
                .Select(m => new ActivityViewModel()
                {
                    Id = m.Id,
                    Topic = m.Topic,
                    Day = m.Start.DayOfWeek.ToString().Substring(0, 3),
                    Date = m.Start.Day,
                    StartHour = m.Start.ToString("H:mm"),
                    EndHour = m.End.ToString("H:mm"),
                    CourseId = m.CourseId,
                    RoomId = m.Course.RoomId
                })
                .FirstOrDefaultAsync();

            if (meeting == null)
            {
                return null;
            }

            return meeting!;


        }

        public async Task<bool> IsMeetingExistsAsync(DateTime start, DateTime end, string courseId, string roomId)
        {
            var isExistsForCourse = await repo.GetAll<Activity>()
                .AnyAsync(m => ((DateTime.Compare(m.Start, start) == 0 || DateTime.Compare(m.End, end) == 0 || (DateTime.Compare(m.Start, start) > 0 && DateTime.Compare(m.Start, end) < 0) || (DateTime.Compare(m.End, start) > 0 && DateTime.Compare(m.End, end) < 0)) && m.CourseId == courseId));

            var isExistForRoom = await repo.GetAll<Activity>()
                .Include(a =>a.Course)
                .AnyAsync(m => ((DateTime.Compare(m.Start, start) == 0 || DateTime.Compare(m.End, end) == 0 || (DateTime.Compare(m.Start, start) > 0 && DateTime.Compare(m.Start, end) < 0) || (DateTime.Compare(m.End, start) > 0 && DateTime.Compare(m.End, end) < 0)) && m.Course.RoomId == roomId));


            return isExistsForCourse || isExistForRoom;
        }

        public async Task<string> CreateAsync(ActivityQueryModel model)
        {
            var activity = new Activity()
            {
                Topic = model.Topic,
                CourseId = model.CourseId,
                End = model.End,
                Start = model.Start,
                
            };

            await repo.AddAsync(activity);
            await repo.SaveChangesAsync();

            return activity.Id;
        }
    }
}
