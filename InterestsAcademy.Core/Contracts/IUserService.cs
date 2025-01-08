using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
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

        Task<List<IdentityRole>> GetRolesAsync();

        Task<string> GetRoleNameAsync(string roleId);

        Task ChangeUserIsApprovedAsync(string userId);

        Task<bool> IsExistsByIdAsync(string id);

        Task<string> GetUserIdByTeacherId(string teacherId);


    }
}
