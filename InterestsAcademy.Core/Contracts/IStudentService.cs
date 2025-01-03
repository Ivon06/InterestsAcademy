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
    }
}
