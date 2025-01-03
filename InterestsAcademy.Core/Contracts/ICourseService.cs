using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseCardViewModel>> GetAllCoursesCards();

        Task<IEnumerable<CourseCardViewModel>> GetAllStudentCoursesCards(string studentId);

        Task<IEnumerable<CourseCardViewModel>> GetAllTeacherCourses(string teacherId);

        Task AddCourse(CourseQueryModel model);

        Task<bool> IsCourseValid(string courseId);

        Task<string> GetCourseNameById(string courseId);

        

        Task<string> GetCourseIdByName(string courseName);
    }
}
