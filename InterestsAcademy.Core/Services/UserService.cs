using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<bool> IsExistByEmail(string email)
        {
            bool result = repo.GetAll<User>()
                .AsNoTracking()
                .Select(x => x.Email)
                .Contains(email);

            return result;
        }
    }
}
