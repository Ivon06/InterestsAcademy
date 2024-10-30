using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IUserService
    {
        Task<bool> IsExistByEmail(string email);

        Task<User?> GetByEmailAsync(string email);
    }
}
