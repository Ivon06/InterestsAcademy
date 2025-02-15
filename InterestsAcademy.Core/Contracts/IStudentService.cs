using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IStudentService
    {
        Task CreateAsync(string userId);
        Task<string?> GetStudentId(string userId);
        Task<string> GetStudentIdByRequestId(string requestId);
    Task<bool> IsStudentAsync(string userId);
        Task<bool> IsNameValid(string name);
        Task<bool> IsEmailValid(string email);

        Task<List<string>> GetAllStudentsUsersIdsByCourseId(string courseId);

        Task<bool> IsStudentInCourse(string studentId, string courseId);
    }
}
