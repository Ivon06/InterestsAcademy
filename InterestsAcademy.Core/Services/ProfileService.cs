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
    public class ProfileService : IProfileService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;

        public ProfileService(IRepository repo, IImageService imageService)
        {
            this.repo = repo;
            this.imageService = imageService;
        }

        public async Task<ProfileViewModel> GetUserProfileAsync(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            var model = new ProfileViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Address = user.Address,
                City = user.City,
                Country = user.Country,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName

            };

            return model;

        }

        public async Task<EditProfileViewModel> GetProfileForEditAsync(string userId)
        {
            var profile = await repo.GetByIdAsync<User>(userId);

            var model = new EditProfileViewModel()
            {
                Id = profile.Id,
                Name = profile.Name,
                UserName = profile.UserName,
                Address = profile.Address,
                City = profile.City,
                Country = profile.Country,
                PhoneNumber = profile.PhoneNumber,

            };

            return model;
        }

        public async Task EditProfileAsync(EditProfileViewModel model)
        {
            var profile = await repo.GetByIdAsync<User>(model.Id);

            if (profile == null)
            {
                return;
            }

            profile.Name = model.Name;
            profile.Address = model.Address;
            profile.City = model.City;
            profile.Country = model.Country;
            profile.Email = model.Email;
            profile.PhoneNumber = model.PhoneNumber;
            profile.UserName = model.UserName;

            if (model.ProfilePicture != null)
                profile.ProfilePictureUrl = await imageService.UploadImage(model.ProfilePicture, "projectImages", profile);

           
            await repo.SaveChangesAsync();

        }

        

    }
}
