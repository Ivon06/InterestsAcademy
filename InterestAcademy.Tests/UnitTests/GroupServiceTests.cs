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
using InterestsAcademy.Core.Hubs;
using Microsoft.AspNetCore.SignalR;
using static InterestAcademy.Tests.UnitTests.DbSeeder;
using InterestsAcademy.Data.Models;

namespace InterestAcademy.Tests.UnitTests
{
    public class GroupServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IGroupService groupService;
        private Mock<IHubContext<PrivateChatHub>> hubContextMock;


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
            this.hubContextMock = new Mock<IHubContext<PrivateChatHub>>();

            groupService = new GroupService(repo,hubContextMock.Object);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }


        [Test]
        public async Task AddUserToGroupShouldAddUserToGroup()
        {
            string groupName = "testGroup";
            string fromUsername = "teacherTest2";
            string toUsername = "studentTest";

            await groupService.AddUserToGroup(groupName, toUsername, fromUsername);

            var result = await repo.GetAll<Group>()
                .AnyAsync(g => g.Name == groupName);

            var resultToUser = await repo.GetAll<Group>()
                .Include(g => g.UsersGroups)
                .AnyAsync(g => g.UsersGroups.Any(u => u.User.UserName == toUsername));
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(resultToUser, Is.True);
            });
        }

        [Test]
        [TestCase("tesst")]
        [TestCase("username")]
        [TestCase("user")]
        public async Task AddUserToGroupShouldDoNothingWithIncorrectUsername(string toUsername)
        {
            string groupName = "testGroup2";
            string fromUsername = "teacherTest";
            await groupService.AddUserToGroup(groupName, toUsername, fromUsername);

            var result = await repo.GetAll<Group>()
                .AnyAsync(g => g.Name == groupName);

            Assert.That(result, Is.False);
        }
        [Test]
        [TestCase("tesst")]
        [TestCase("username")]
        [TestCase("user")]
        public async Task AddUserToGroupShouldDoNothingWithIncorrectFromUsername(string fromUsername)
        {
            string groupName = "testGroup2";
            string toUsername = "teacherTest";
            await groupService.AddUserToGroup(groupName, toUsername, fromUsername);

            var result = await repo.GetAll<Group>()
                .AnyAsync(g => g.Name == groupName);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task AddUserToGroupShouldAddNewGroupIfThatDoesNotExists()
        {
            string groupName = "newTestGroup";
            string fromUsername = "teacherTest2";
            string toUsername = "studentTest";
            await groupService.AddUserToGroup(groupName, toUsername, fromUsername);

            var result = await repo.GetAll<Group>()
               .AnyAsync(g => g.Name == groupName);

            var resultToUser = await repo.GetAll<Group>()
                .Include(g => g.UsersGroups)
                .AnyAsync(g => g.UsersGroups.Any(u => u.User.UserName == toUsername));
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(resultToUser, Is.True);
            });

        }

        [Test]
        public async Task GetGroupBetweenUsersAsyncShouldReturnCorrectResult()
        {
            string userId = "28a172eb-6e0d-43ed-9a42-fb28025e1659";
            string receiverId = "bae65efa-6885-4144-9786-0719b0e2ebc4";

            var result = await groupService.GetGroupBetweenUsersAsync(userId, receiverId);

            string expectedResult = "bd0fd8e0-70ca-4475-9bef-d6ca66daefa1";

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.EqualTo(expectedResult));
            });

        }

        [Test]
        [TestCase("17cd4d78-a621-4bf3-a4a4-9d7d3af085d2")]
        [TestCase("608924f2-e51d-4686-b1eb-1f33b5dd6aa7")]
        public async Task GetGroupBetweenUsersAsyncShouldReturnNullWithIncorrectUserId(string userId)
        {
            string receiverId = "eb8fc718-655e-4d32-9a0a-d905fa3956e7";

            var result = await groupService.GetGroupBetweenUsersAsync(userId, receiverId);

            Assert.That(result, Is.Null);
        }

        [Test]
        [TestCase("17cd4d78-a621-4bf3-a4a4-9d7d3af085d2")]
        [TestCase("608924f2-e51d-4686-b1eb-1f33b5dd6aa7")]
        public async Task GetGroupBetweenUsersAsyncShouldReturnNullWithIncorrectReceiverId(string receiverId)
        {
            string userId = "28a172eb-6e0d-43ed-9a42-fb28025e1659";

            var result = await groupService.GetGroupBetweenUsersAsync(userId, receiverId);

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetGroupNameByIdAsyncShouldReturnCorrectResult()
        {
            string groupId = "bd0fd8e0-70ca-4475-9bef-d6ca66daefa1";

            var result = await groupService.GetGroupNameByIdAsync(groupId);
            string expectedResult = "testGroup";

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.EqualTo(expectedResult));
            });
        }

        [Test]
        [TestCase("kh9y-uh8-ll-4bf3-a4a4-9d7d3af085d2")]
        [TestCase("h8t57fd-e5hfd-4686-6tei-1f33b5dd6aa7")]
        public async Task GetGroupNameByIdAsyncShouldReturnNull(string groupId)
        {

            var result = await groupService.GetGroupNameByIdAsync(groupId);


            Assert.That(result, Is.Null);

        }
    }
}
