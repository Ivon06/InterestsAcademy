using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
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
    }
}
