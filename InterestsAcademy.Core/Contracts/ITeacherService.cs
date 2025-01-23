
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface ITeacherService
    {
        Task<bool> IsTeacherAsync(string userId);
        Task<string> GetTeacherIdByUserId(string userId);

        Task CreateAsync(string userId);

        Task<string?> GetTeacherIdByCourseNameAsync(string courseName);
    }
}
