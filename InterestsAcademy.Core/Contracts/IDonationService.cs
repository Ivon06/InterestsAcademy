using InterestsAcademy.Core.Models.Donation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IDonationService
    {
        Task<FilterDonationViewModel> GetAll();
        Task<FilterDonationViewModel> GetAllByCategory(string category);

        Task<string> Add(AddDonationQueryModel model);
    }
}
