﻿using InterestsAcademy.Core.Models.User;
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

        Task<User> GetByIdAsync(string id);
        Task<string> GetUserIdByStudentId(string studentId);

        Task<UsersQueryModel> GetAllUsersAsync();

        Task DeleteUser(string userId);
        Task ChangeApproveToFalse(string userId);
        Task<string?> GetUserIdByUsernameAsync(string username);


    }
}
