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
using Moq;

namespace InterestAcademy.Tests.UnitTests
{
    public class StudentServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IStudentService studentService;


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

            studentService = new StudentService(repo);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4")]
        public async Task GetStudentId_ShouldWorkCorrectly(string userId)
        {
            string result = await studentService.GetStudentId(userId);
            Assert.That(result, Is.EqualTo("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b"));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetStudentId_ShouldReturnNull(string userId)
        {
            string result = await studentService.GetStudentId(userId);
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        [TestCase("3wjjdiskj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetStudentIdByRequestId_ShouldWorkCorrectly(string requestId)
        {
            string? result = await studentService.GetStudentIdByRequestId(requestId);
            Assert.That(result, Is.EqualTo("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b"));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetStudentIdByRequestId_ShouldReturnNull(string requestId)
        {
            string? result = await studentService.GetStudentIdByRequestId(requestId);
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4")]
        public async Task IsStudentAsync_UserIsStudent_ReturnsTrue(string userId)
        {

            var result = await studentService.IsStudentAsync(userId);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsStudentAsync_UserIsStudent_ReturnsFalse(string userId)
        {

            var result = await studentService.IsStudentAsync(userId);

            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Студент Студентов")]
        public async Task IsNameValid_NameExists_ReturnsTrue(string name)
        {

            var result = await studentService.IsNameValid(name);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsNameValid_NameExists_ReturnsFalse(string name)
        {

            var result = await studentService.IsNameValid(name);

            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("studentStudentov@abv.bg")]
        public async Task IsEmailValid_EmailExists_ReturnsTrue(string email)
        {

            var result = await studentService.IsEmailValid(email);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsEmailValid_EmailExists_ReturnsFalse(string email)
        {

            var result = await studentService.IsEmailValid(email);

            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetAllStudentsUsersIdsByCourseId_ShouldWorkCorrectly(string courseId)
        {
            List<string> result = await studentService.GetAllStudentsUsersIdsByCourseId(courseId);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0], Is.EqualTo("bae65efa-6885-4144-9786-0719b0e2ebc4"));
        }


        [Test]
        [TestCase(" ")]
        [TestCase("something")]
        public async Task GetAllStudentsUsersIdsByCourseId_ShouldRetirnNull(string courseId)
        {
            List<string> result = await studentService.GetAllStudentsUsersIdsByCourseId(courseId);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4", "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b")]
        public async Task CreateAsync_ShouldWorkCorrectly(string userId, string studentId)
        {
            await studentService.CreateAsync(userId);
            var student = await repo.GetByIdAsync<Student>(studentId);
            Assert.That(student, Is.Not.Null);
        }

        [Test]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4", "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task IsStudentInCourse_ShouldReturnTrue(string studentId, string courseId)
        {
            var result = await studentService.IsStudentInCourse(studentId, courseId);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(" ", "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        [TestCase("bae65efa-6885-4144-9786-0719b0e2ebc4", " ")]
        public async Task IsStudentInCourse_ShouldReturnFalse(string studentId, string courseId)
        {
            var result = await studentService.IsStudentInCourse(studentId, courseId);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetAllStudentsCount_ShouldWorkCorrectly()
        {
            int result = await studentService.GetAllStudentsCount();
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
