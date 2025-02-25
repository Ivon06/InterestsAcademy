using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Repository.Contracts;
using InterestsAcademy.Data.Repository;
using InterestsAcademy.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static InterestAcademy.Tests.UnitTests.DbSeeder;
using InterestsAcademy.Core.Models.Donation;
using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Data.Models;
using Org.BouncyCastle.Crypto;

namespace InterestAcademy.Tests.UnitTests
{
    public class DonationServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IDonationService donationService;

        [SetUp]
        public void Setup()
        {
            this.dbOptions = new DbContextOptionsBuilder<InterestsAcademyDbContext>()
                 .UseInMemoryDatabase("InterestAcademy" + Guid.NewGuid().ToString())
                     .Options;

            this.dbContext = new InterestsAcademyDbContext(dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);
            repo = new Repository(this.dbContext);

            donationService = new DonationService(repo);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        public async Task Add_ShouldAddItem()
        {
            AddDonationQueryModel model = new AddDonationQueryModel
            {
                ItemName = "TestItem",
                Category = DonationCategoryEnum.Other.ToString(),
                Quantity = 3,

            };

            await donationService.Add(model);

            var items =  repo.GetAll<MaterialBaseItem>();

            Assert.That( items.Count, Is.EqualTo(3));

        }

        [Test]
        public async Task GetAll()
        {
            var items = await donationService.GetAll();
            Assert.That(items.Donations.Count, Is.EqualTo(2));
        }

        [Test]
        [TestCase("Biology")]
        public async Task GetAllByCategory(string category)
        {
            var items = await donationService.GetAllByCategory(category);
            Assert.That(items.Donations.Count, Is.EqualTo(1));
        }

        [Test]
        [TestCase("s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetItemForDonate(string id)
        {
            var item = await donationService.GetItemForDonate(id);
            Assert.That(item, Is.Not.Null);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]

        public async Task GetItemForDonate_ShouldReturnNull(string id)
        {
            var item = await donationService.GetItemForDonate(id);
            Assert.That(item, Is.Null);
        }

        [Test]
        [TestCase("s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task Donate(string id)
        {
            var model = new CreateDonationViewModel
            {
                Id = id,
                Quantity = 1,
                Category = DonationCategoryEnum.Physics.ToString(),
                ItemName = "Телескоп",
                GiverEmail = "email@abv.bg",
                GiverName = "TestName"
            };
           
            await donationService.Donate(model);
            var item = await donationService.GetItemForDonate(id);
            Assert.That(item.NeededQuantity, Is.EqualTo(4));
        }

        [Test]
        [TestCase("s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task IsItemValid(string id)
        {
            var result = await donationService.IsItemValid(id);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsItemValid_ShouldReturnFalse(string id)
        {
            var result = await donationService.IsItemValid(id);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetAllDonatedItems(string materialBaseItemId)
        {
            var items = await donationService.GetAllDonatedItems(materialBaseItemId);

            Assert.That(items.Count, Is.EqualTo(1));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        [TestCase("snj9-iw9-s9dy-w9")]
        public async Task GetAllDonatedItems_ShouldReturnEmptyList(string materialBaseItemId)
        {
            var items = await donationService.GetAllDonatedItems(materialBaseItemId);
            Assert.That(items.Count, Is.EqualTo(0));
        }

        [Test]
        [TestCase("s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task AdminDonations(string materialBaseItemId)
        {
            var items = await donationService.AdminDonations(materialBaseItemId);
            Assert.That(items.DonatedItems.Count, Is.EqualTo(1));
        }

    }
}
