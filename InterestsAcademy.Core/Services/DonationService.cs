using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Donation;
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
    public class DonationService : IDonationService
    {
        private readonly IRepository repo;

        public DonationService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<FilterDonationViewModel> GetAll()
        {
            var model = new FilterDonationViewModel();

            var items = await repo.GetAll<MaterialBaseItem>()
                .Select(i => new DonationViewModel()
                {
                    Id = i.Id,
                    ItemName = i.Name,
                    Quantity = i.NeededQuantity,
                    Category = i.Category,

                })
                .ToListAsync();

            model.Donations = items;

            return model;

        }

        public async Task<FilterDonationViewModel> GetAllByCategory(string category)
        {
            var model = new FilterDonationViewModel();

            var items = await repo.GetAll<MaterialBaseItem>()
                .Where(i =>  i.Category == category)
                .Select(i => new DonationViewModel()
                {
                    Id = i.Id,
                    ItemName = i.Name,
                    Quantity = i.NeededQuantity,
                    Category = i.Category,

                })
                .ToListAsync();

            model.Donations = items;
            model.Categoty = category;

            return model;

        }
    }
}
