using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repo;

        public TeacherService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<string?> GetTeacherIdByCourseNameAsync(string courseName)
        {
            var result = await repo.GetAll<Course>()
                .Include(c => c.Teacher)
                .Where(c => c.Name == courseName)
                .FirstOrDefaultAsync();

            return result.TeacherId;
        }

        public async Task CreateAsync(string userId)
        {
            Teacher teacher = new Teacher()
            {
                UserId = userId,
            };

            await repo.AddAsync(teacher);
            await repo.SaveChangesAsync();
        }

        public async Task<string> GetTeacherIdByUserId(string userId)
        {
           var result = await repo.GetAll<Teacher>()
                .FirstOrDefaultAsync(t => t.UserId == userId);

            return result!.Id;
        }

        public async Task<bool> IsTeacherIdValidAsync(string teacherId)
        {
            var isTeacher = await repo.GetByIdAsync<Teacher>(teacherId);
                return  isTeacher == null ? false :true;
        }

        public async Task<bool> IsTeacherAsync(string userId)
        {
            var isTeacher = await repo.GetAll<Teacher>()
                .AnyAsync(t => t.UserId == userId && t.User.IsActive == true);

            return isTeacher;
        }

        public async Task<List<string>> GetAllTeacherUsersIdByRoomId(string roomId)
        {
            var ids = await repo.GetAll<Course>()
                .Include(c => c.Teacher)
                .Where(c => c.RoomId == roomId)
                .Select(c => c.Teacher.UserId)
                .ToListAsync();

            return ids;
        }

        public async Task<bool> ApproveTeacher(string teacherId)
        {
            var user = await repo.GetAll<User>()
                .FirstOrDefaultAsync(t=>t.Id == teacherId);

            user.IsApproved = true;

            await repo.SaveChangesAsync();

            return user.IsApproved;


        }
    }
}
