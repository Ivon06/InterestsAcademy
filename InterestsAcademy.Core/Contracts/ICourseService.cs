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

    }
}
