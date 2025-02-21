using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository;
using InterestsAcademy.Data.Repository.Contracts;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Moq;
using MockQueryable;
using MockQueryable.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestAcademy.Tests.UnitTests.DbSeeder;
using Microsoft.Identity.Client;

namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class TeacherServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private ITeacherService teacherService;
        

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
            
            teacherService = new TeacherService(repo);
    
        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        [TestCase("Курс по роботика")]
        public async Task GetTeacherIdByCourseNameAsync_ShouldReturnTeacherId(string courseName)
        {

            var teacherId = await teacherService.GetTeacherIdByCourseNameAsync(courseName);

            Assert.That(teacherId, Is.EqualTo("hugf73-3b3b-3b3b-3b3b-jb7ftyv"));
        }

        [Test]
        [TestCase("something")]
        [TestCase(" ")]
        public async Task GetTeacherIdByCourseNameAsync_ShouldReturnNull(string courseName)
        {

            var teacherId = await teacherService.GetTeacherIdByCourseNameAsync(courseName);

            Assert.That(teacherId, Is.EqualTo(null));
        }

        [Test]
        [TestCase("28a172eb-6e0d-43ed-9a42-fb28025e1659")]
        public async Task GetTeacherIdByUserId(string userId)
        {
            var result = await teacherService.GetTeacherIdByUserId(userId);

            Assert.That(result, Is.EqualTo("hugf73-3b3b-3b3b-3b3b-jb7ftyv"));
        }

        [Test]
        [TestCase("something")]
        [TestCase(" ")]
        public async Task GetTeacherIdByUserId_ShouldReturnNull(string userId)
        {
            var result = await teacherService.GetTeacherIdByUserId(userId);

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        [TestCase("hugf73-3b3b-3b3b-3b3b-jb7ftyv")]
        public async Task IsTeacherIdValid_ShouldWorkCorrectly(string teacherId)
        {
            var result = await teacherService.IsTeacherIdValidAsync(teacherId);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task IsTeacherIdValid_ShouldReturnFalse(string teacherId)
        {
            var result = await teacherService.IsTeacherIdValidAsync(teacherId);

            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("28a172eb-6e0d-43ed-9a42-fb28025e1659")]
        public async Task IsTeacherAsync_ShouldReturnTrue(string userId)
        {
            bool result = await teacherService.IsTeacherAsync(userId);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task IsTeacherAsync_ShouldReturnFalse(string userId)
        {
            bool result = await teacherService.IsTeacherAsync(userId);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3c")]
        public async Task GetAllTeacherUsersIdByRoomId_ShouldWorkCorrectly(string roomId)
        {
            var actual = await teacherService.GetAllTeacherUsersIdByRoomId(roomId);

            var expected = new List<string> { "28a172eb-6e0d-43ed-9a42-fb28025e1659" };

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task GetAllTeacherUsersIdByRoomId_ShouldReturnNull(string roomId)
        {
            var actual = await teacherService.GetAllTeacherUsersIdByRoomId(roomId);

            var expected = new List<string> { };

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task CreateTeacher_ShouldWorkCorrectly(string userID)
        {
            await teacherService.CreateAsync(userID);

            var teachers = repo.GetAll<Teacher>();

            Assert.That(teachers.Count, Is.EqualTo(2));
        }

        [Test]
        [TestCase("hsu80-uq90d-43ed-9a42-fb28025e1659")]
        public async Task ApproveTeacher_ShouldWorkCorrectly(string id)
        {
            bool result = await teacherService.ApproveTeacher(id);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task ApproveTeacher_ShouldReturnFalse(string id)
        {
            bool result = await teacherService.ApproveTeacher(id);

            Assert.That(result, Is.False);
        }

    }
}
