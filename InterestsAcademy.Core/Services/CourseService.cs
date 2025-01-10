using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

        public async Task AddCourse(CourseQueryModel model)
        {
            var course = new Course()
            {
                Name = model.Name,
                Description = model.Description,
                TeacherId = model.TeacherId,
                RoomId = model.RoomId,
            };

            await repo.AddAsync(course);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllCoursesCards()
        {
            var result = await repo.GetAll<Course>()
                .Select(x => new CourseCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    TeacherId = x.TeacherId
                }
                )
                .ToListAsync();

            return result;


        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllStudentCoursesCards(string studentId)
        {
            var result = await repo.GetAll<StudentCourse>()
                 .Include(c => c.Student)
                 .Include(c=>c.Course)
                 .Include(c => c.Course.Teacher)
                 .Where(c => c.IsApproved == true &&  c.StudentId == studentId)
                 .Select(x => new CourseCardViewModel()
                 {
                     Id = x.Course.Id,
                     Name = x.Course.Name,
                     Description = x.Course.Description,
                     TeacherId = x.Course.TeacherId
                 }
                 )
                 .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllTeacherCourses(string teacherId)
        {
            var result = await repo.GetAll<Course>()
                .Where(c => c.TeacherId == teacherId)
                 .Select(x => new CourseCardViewModel()
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Description = x.Description,
                     TeacherId = x.TeacherId
                 }
                 )
                 .ToListAsync();

            return result;
        }

        public async Task<bool> IsCourseValid(string courseId)
        {
            var result = await repo.GetAll<Course>()
                .AnyAsync(c => c.Id == courseId);

            return result;
        }

        public async Task<string> GetCourseNameById(string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            return course!.Name;

        }

        

        public async Task<string> GetCourseIdByName(string courseName)
        {
            var result = await repo.GetAll<Course>()
                .FirstOrDefaultAsync(c => c.Name == courseName);

            return result.Id;
        }

        public async Task AddStudentToCourse(string studentId, string courseId)
        {
            StudentCourse sc = new StudentCourse()
            {
                StudentId = studentId,
                CourseId = courseId,
                IsApproved = true
            };

            await repo.AddAsync(sc);
            await repo.SaveChangesAsync();

        }

        public async Task<string> GetCourseIdByRequestId(string requestId)
        {
            var result = await repo.GetByIdAsync<Request>(requestId);

            return result.CourseId; 
                
        }
    }
}
