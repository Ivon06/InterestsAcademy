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
using InterestsAcademy.Data.Models;

namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IUserService userService;


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

            userService = new UserService(repo);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        [TestCase("studentStudentov@abv.bg")]
        public async Task GetByEmailAsync_ShouldReturnUser_WhenEmailExists(string testEmail)
        {
            var user = await userService.GetByEmailAsync(testEmail);

            Assert.NotNull(user);
            Assert.That(testEmail, Is.EqualTo(user.Email));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetByEmailAsync_ShouldReturnNull_WhenEmailNotExists(string testEmail)
        {

            var user = await userService.GetByEmailAsync(testEmail);


            Assert.That(user, Is.Null);
        }

        [Test]
        [TestCase("78374b9b-5158-4aff-8626-d088a02d79e1")]
        public async Task GetRoleNameAsync_ShouldReturnRoleName(string roleId)
        {
            var roleName = await userService.GetRoleNameAsync(roleId);
            Assert.That(roleName, Is.EqualTo("Teacher"));
        }

        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task GetRoleNameAsync_ShouldReturnNull(string roleId)
        {
            var roleName = await userService.GetRoleNameAsync(roleId);
            Assert.That(roleName, Is.EqualTo(""));
        }

        [Test]
        public async Task GetRolesAsync_ShouldReturnAllRoles()
        {
            var roles = await userService.GetRolesAsync();
            Assert.That(roles.Count, Is.EqualTo(3));
        }

        [Test]
        [TestCase("studentStudentov@abv.bg")]
        public async Task IsExistByEmail_ShouldReturnTrue_WhenEmailExists(string testEmail)
        {
            var result = await userService.IsExistByEmail(testEmail);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsExistByEmail_ShouldReturnFalse(string testEmail)
        {

            var user = await userService.IsExistByEmail(testEmail);


            Assert.That(user, Is.False);
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task ChangeUserIsApprovedAsync_ShouldChangeIsApprovedToTrue(string userId)
        {
            await userService.ChangeUserIsApprovedAsync(userId);
            var user = await repo.GetByIdAsync<User>(userId);
            Assert.That(user.IsApproved, Is.True);
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task IsExistsByIdAsync_ShouldReturnTrue(string userId)
        {
            var result = await userService.IsExistsByIdAsync(userId);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsExistsByIdAsync_ShouldReturnFalse(string userId)
        {
            var result = await userService.IsExistsByIdAsync(userId);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("hugf73-3b3b-3b3b-3b3b-jb7ftyv")]
        public async Task GetUserIdByTeacherId_ShouldWorkCorrectly(string teacherId)
        {
            var result = await userService.GetUserIdByTeacherId(teacherId);
            Assert.That(result, Is.EqualTo("28a172eb-6e0d-43ed-9a42-fb28025e1659"));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetUserIdByTeacherId_ShouldReturnNull(string teacherId)
        {
            var result = await userService.GetUserIdByTeacherId(teacherId);
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        [TestCase("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b")]
        public async Task GetUserIdByStudentId_ShouldWorkCorrectly(string studentId)
        {
            var result = await userService.GetUserIdByStudentId(studentId);
            Assert.That(result, Is.EqualTo("bae65efa-6885-4144-9786-0719b0e2ebc4"));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetUserIdByStudentId_ShouldReturnNull(string studentId)
        {
            var result = await userService.GetUserIdByStudentId(studentId);
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4")]
        public async Task GetByIdAsync_ShouldWorkCorrectly(string id)
        {
            var result = await userService.GetByIdAsync(id);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetByIdAsync_ShouldReturnNull(string id)
        {
            var result = await userService.GetByIdAsync(id);
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetAllUsersAsync_ShouldReturnAllUsers()
        {
            var result = await userService.GetAllUsersAsync();
            Assert.That(result.Users.Count, Is.EqualTo(4));
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task DeleteUser(string userId)
        {
            await userService.DeleteUser(userId);
            var user = await repo.GetByIdAsync<User>(userId);
            Assert.That(user.IsActive, Is.False);
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task ChangeApproveToFalse(string userId)
        {
            await userService.ChangeApproveToFalse(userId);
            var user = await repo.GetByIdAsync<User>(userId);
            Assert.That(user.IsApproved, Is.False);
        }
    }
}
