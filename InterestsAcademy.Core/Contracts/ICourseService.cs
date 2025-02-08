using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Core.Models.Request;
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

        Task AddStudentToCourse(string studentId, string courseId);

        Task<string> GetCourseIdByName(string courseName);

        Task<string> GetCourseIdByRequestId(string requestId);

        Task<EditCourseViewModel> GetCourseForEdit(string id);

        Task<AllRequestViewModel> GetCourseWithAllRequest(string courseId);

        Task<bool> IsCourseApproved(string courseId);

        Task<bool> ApproveCourse(EditCourseViewModel model);
        Task<bool> IsCourseValidForTeacher(string courseId, string teacherId);
        Task<List<CourseCardViewModel>> GetAllCoursesByRoomId(string roomId);
    }
}
