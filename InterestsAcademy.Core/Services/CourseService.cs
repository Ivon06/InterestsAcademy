using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
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
    public class CourseService : ICourseService
    {
        private readonly IRepository repo;

        public CourseService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllCoursesCards()
        {
            var result = await repo.GetAll<Course>()
                .Select(x => new CourseCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                }
                )
                .ToListAsync();

            return result;


        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllStudentCoursesCards(string studentId)
        {
            var result = await repo.GetAll<Course>()
                
                 .Select(x => new CourseCardViewModel()
                 {
                     Id = x.Id,
                     Name = x.Name,
                 }
                 )
                 .ToListAsync();

            return result;
        }
    }
}
