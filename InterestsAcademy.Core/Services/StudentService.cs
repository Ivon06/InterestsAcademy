﻿using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repo;

        public StudentService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task CreateAsync(string userId)
        {
            Student student = new Student()
            {
                UserId = userId
            };


            await repo.AddAsync(student);
            await repo.SaveChangesAsync();

        }

        public async Task<string?> GetStudentId(string userId)
        {
            var student = await repo.GetAll<Student>()
                .Include(s => s.User)
                .FirstOrDefaultAsync(student => student.UserId == userId && student.User.IsActive);

            return student == null ? null : student.Id;
        }

        public async Task<string?> GetStudentIdByRequestId(string requestId)
        {
            var request = await repo.GetByIdAsync<Request>(requestId);

            return request == null ? null : request.StudentId;
        }

        public async Task<bool> IsStudentAsync(string userId)
        {
            var isStudent = await repo.GetAll<Student>()
                .AnyAsync(s => s.UserId == userId && s.User.IsActive == true);

            return isStudent;
        }

        public async Task<bool> IsNameValid(string name)
        {
            var result = await repo.GetAll<Student>()
                .Include(s => s.User)
                .AnyAsync(s => s.User.Name == name);

            return result;
        }

        public async Task<bool> IsEmailValid(string email)
        {
            var result = await repo.GetAll<Student>()
               .Include(s => s.User)
               .AnyAsync(s => s.User.Email == email);

            return result;
        }

        public async Task<List<string>> GetAllStudentsUsersIdsByCourseId(string courseId)
        {
            List<string> ids = await repo.GetAll<StudentCourse>()
                 .Include(sc => sc.Student)
                 .Where(sc => sc.CourseId == courseId && sc.IsApproved)
                 .Select(sc => sc.Student.UserId)
                 .ToListAsync();

            return ids;
        }

        public async Task<bool> IsStudentInCourse(string studentId, string courseId)
        {
            var id = await GetStudentId(studentId);

            var result = await repo.GetAll<Request>()
                .AnyAsync(sc => sc.StudentId == id && sc.CourseId == courseId );

            return result;
        }

        public async Task<int> GetAllStudentsCount()
        {
            int result = await repo.GetAll<Student>().CountAsync();
            return result;
        }
    }
}
