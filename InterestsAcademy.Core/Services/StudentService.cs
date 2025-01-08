using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<string> GetStudentIdByRequestId(string requestId)
        {
            var request = await repo.GetByIdAsync<Request>(requestId);

            return request.StudentId;
        }

        public async Task<bool> IsStudentAsync(string userId)
        {
            var isStudent = await repo.GetAll<Student>()
                .AnyAsync(s => s.UserId == userId && s.User.IsActive == true);

            return isStudent;
        }
    }
}
