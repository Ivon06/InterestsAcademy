using InterestsAcademy.Core.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IProfileService
    {
        Task<ProfileViewModel> GetUserProfileAsync(string userId);
    }
}
