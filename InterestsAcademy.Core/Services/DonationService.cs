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

        public async Task<string> Add(AddDonationQueryModel model)
        {
            MaterialBaseItem item = new MaterialBaseItem()
            {
                Name = model.ItemName,
                NeededQuantity = model.Quantity,
                Category = model.Category
            };

            await repo.AddAsync(item);
            await repo.SaveChangesAsync();

            return item.Id;
        }

        public async Task<FilterDonationViewModel> GetAll()
        {
            var model = new FilterDonationViewModel();

            var items = await repo.GetAll<MaterialBaseItem>()
                .Where(m => m.NeededQuantity > 0)
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
                .Where(i => i.Category == category && i.NeededQuantity > 0)
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

     
        public async Task<CreateDonationViewModel> GetItemForDonate(string id)
        {
            var item = await repo.GetByIdAsync<MaterialBaseItem>(id);

            CreateDonationViewModel model = new CreateDonationViewModel()
            {
                Id = item.Id,
                ItemName = item.Name,
                NeededQuantity = item.NeededQuantity,
                Category = item.Category
            };

            return model;
        }

        public async Task Donate(CreateDonationViewModel model)
        {
            var item = await repo.GetByIdAsync<MaterialBaseItem>(model.Id);
            item.NeededQuantity -= model.Quantity;

            GivenThing gt = new GivenThing()
            { 
                Category=item.Category,
                Name = item.Name,
                GiverEmail = model.GiverEmail,
                GiverName = model.GiverName,
                Quantity = model.Quantity,
                MaterialBaseItemId = item.Id
            };

            await repo.AddAsync(gt);

            await repo.SaveChangesAsync();
        }

        public async Task<bool> IsItemValid(string itemId)
        {
            var item = await repo.GetByIdAsync<MaterialBaseItem>(itemId);
            return item == null ? false : true;
        }

        public async Task<List<DonatedItemViewModel>> GetAllDonatedItems(string itemId)
        {
            var items = await repo.GetAll<GivenThing>()
                
                .Where(i => i.MaterialBaseItemId == itemId)
                .Select(i => new DonatedItemViewModel()
                {
                    Id = i.Id,
                    UserEmail = i.GiverEmail,
                    Quantity = i.Quantity,
                    UserName = i.GiverName,

                })
                .ToListAsync();

            return items;
        }

        public async Task<AllDonationsForAdminViewModel> AdminDonations(string itemId)
        {
           var model = new AllDonationsForAdminViewModel();

            model.DonatedItems = await GetAllDonatedItems(itemId);

            var item = await repo.GetByIdAsync<MaterialBaseItem>(itemId);

            model.ItemName = item.Name;
            model.NeededQuantity = item.NeededQuantity;
            model.Category = item.Category;

            return model;
        }
    }
}
