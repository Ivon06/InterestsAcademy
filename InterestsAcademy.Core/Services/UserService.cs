using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.User;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        public UserService(IRepository repository)
        {
            repo = repository;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
           User? user = await repo.GetAll<User>()
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email);

            return user;
        }

        public async Task<string> GetRoleNameAsync(string roleId)
        {
            var result = await repo.GetByIdAsync<IdentityRole>(roleId);

            return result==null?"":result.Name;
                
        }

        public async Task<List<IdentityRole>> GetRolesAsync()
        {
            var result = await repo.GetAll<IdentityRole>()
                .ToListAsync();

            return result;
        }
            
        public async Task<bool> IsExistByEmail(string email)
        {
            bool result = repo.GetAll<User>()
                .AsNoTracking()
                .Select(x => x.Email)
                .Contains(email);

            return result;
        }

        public async Task ChangeUserIsApprovedAsync(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            if (user == null)
            {
                return;
            }

            user!.IsApproved = true;

            await repo.SaveChangesAsync();

        }

        public async Task<bool> IsExistsByIdAsync(string id)
        {
            var isExists = await repo.GetAll<User>().AnyAsync(u => u.Id == id);

            return isExists;
        }

        public async Task<string> GetUserIdByTeacherId(string teacherId)
        {
            var result = await repo.GetByIdAsync<Teacher>(teacherId);
            return result==null? "":result.UserId;

        }

        public async Task<string> GetUserIdByStudentId(string studentId)
        {
            var result = await repo.GetByIdAsync<Student>(studentId);
            return result == null ? "" : result.UserId;

        }

        public async Task<User> GetByIdAsync(string id)
        {
            var result = await repo.GetByIdAsync<User>(id);
            return result;
        }

        public async Task<UsersQueryModel> GetAllUsersAsync()
        {
            var model = new UsersQueryModel();

            model.Users = await repo.GetAll<User>()
                .Where(u => u.IsActive)
                .Select(u => new UserViewModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    RegisteredOn = u.RegisteredOn.ToString(),
                    ProfilePictureUrl = u.ProfilePictureUrl,
                    IsApproved = u.IsApproved
                })
                .ToListAsync();

            model.UsersCount = model.Users.Count;

            return model;
        }

        public async Task DeleteUser(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            user.IsActive = false;

            await repo.SaveChangesAsync();

        }

        public async Task ChangeApproveToFalse(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            user.IsApproved = false;

            await repo.SaveChangesAsync();
        }
    }
}
