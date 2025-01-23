using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Profile;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public  class ProfileService : IProfileService
    {
        private readonly IRepository repo;

        public ProfileService(IRepository repo)
        {
            this.repo = repo;
        }

         public async Task<ProfileViewModel> GetUserProfileAsync(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            var model = new ProfileViewModel()
            {
                Name=user.Name,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Address = user.Address,
                City = user.City,
                Country=user.Country,
                Email=user.Email,
                PhoneNumber=user.PhoneNumber,
                UserName = user.UserName

            };

            return model;
                
        }

    }
}
