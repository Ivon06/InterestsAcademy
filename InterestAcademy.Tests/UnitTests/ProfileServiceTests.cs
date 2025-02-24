using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Repository.Contracts;
using InterestsAcademy.Data.Repository;
using InterestsAcademy.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static InterestAcademy.Tests.UnitTests.DbSeeder;
using Moq;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Core.Models.Profile;

namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class ProfileServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IProfileService profileService;
        private Mock<IImageService> imageServiceMock;

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
            imageServiceMock = new Mock<IImageService>();

            profileService = new ProfileService(repo, imageServiceMock.Object);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        public async Task EditProfileAsyncShouldEditProfileCorrectly()
        {
            string userId = "hsu80-uq90d-43ed-9a42-fb28025e1659";
            EditProfileViewModel model = new EditProfileViewModel()
            {
                Id = userId,
                Name = "Name edited",
                Email = "Email edited",
                PhoneNumber = "0887896754",
                Country = "Bulgaria edited",
                City = "Kazanlak edited",
                Address = "edited",
                ProfilePicture = null
            };

            await profileService.EditProfileAsync(model);

            var resultUser = await repo.GetByIdAsync<User>(userId);

            Assert.IsNotNull(resultUser);
            Assert.Multiple(() =>
            {
                Assert.That(resultUser.Name, Is.EqualTo(model.Name));
                Assert.That(resultUser.Email, Is.EqualTo(model.Email));
                Assert.That(resultUser.PhoneNumber, Is.EqualTo(model.PhoneNumber));
                Assert.That(resultUser.Address, Is.EqualTo(model.Address));
                Assert.That(resultUser.Country, Is.EqualTo(model.Country));
                Assert.That(resultUser.City, Is.EqualTo(model.City));
            });
        }

        [Test]
        [TestCase("some id")]
        [TestCase("251f-4e9a-aaba-c11d5c4da798")]
        [TestCase("6e0d-43ed-9a42-fb28025e1659")]
        public async Task EditProfileAsyncShouldDoNothingWhenUserDoesNotExists(string userId)
        {
            EditProfileViewModel model = new EditProfileViewModel()
            {
                Name = "Name edited",
                Email = "Email edited",
                PhoneNumber = "0887896754",
                Country = "Bulgaria edited",
                City = "Kazanlak edited",
                Address = "edited",
                ProfilePicture = null
            };

            await profileService.EditProfileAsync(model);

            var resultUser = await repo.GetByIdAsync<User>(userId);

            Assert.IsNull(resultUser);
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task GetProfileAsyncShouldReturnProfileCorrectly(string userId)
        {
            var result = await profileService.GetUserProfileAsync(userId);
            Assert.IsNotNull(result);
            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(userId));
                Assert.That(result.Name, Is.EqualTo("Учител2 Учителов"));
                Assert.That(result.Email, Is.EqualTo("teacher2@abv.bg"));
            });

        }

        [Test]
        [TestCase("some id")]
        [TestCase("251f-4e9a-aaba-c11d5c4da798")]
        [TestCase("6e0d-43ed-9a42-fb28025e1659")]
        public async Task GetProfileAsyncShouldReturnNullWhenUserDoesNotExists(string userId)
        {
            var result = await profileService.GetUserProfileAsync(userId);
            Assert.IsNull(result);
        }


        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4")]
        public async Task GetProfileForEdit(string userId)
        {
            var result = await profileService.GetProfileForEditAsync(userId);

            Assert.IsNotNull(result);
            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(userId));
                Assert.That(result.Name, Is.EqualTo("Студент Студентов"));
                Assert.That(result.UserName, Is.EqualTo("studentTest"));
            });
        }

        [Test]
        [TestCase("some id")]
        [TestCase("251f-4e9a-aaba-c11d5c4da798")]
        [TestCase("6e0d-43ed-9a42-fb28025e1659")]
        public async Task GetProfileForEditShouldReturnNullWhenUserDoesNotExists(string userId)
        {
            var result = await profileService.GetProfileForEditAsync(userId);
            Assert.IsNull(result);
        }

    }
}
