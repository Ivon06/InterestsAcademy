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
using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Core.Models.Request;


namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class RequestServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IRequestService requestService;


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

            requestService = new RequestService(repo);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        [TestCase("3wjjdiskj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetRequestById_ShouldWorkCorrectly(string requestId)
        {
            var result = await requestService.GetRequestByIdAsync(requestId);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetRequestById_ShouldReturnNull_WhenRequestDoesNotExist(string requestId)
        {
            var result = await requestService.GetRequestByIdAsync(requestId);
            Assert.That(result, Is.Null);
        }

        [Test]
        [TestCase("enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetAllRequestByCourseIdAsync_ShouldWorkCorrectly(string courseId)
        {
            var result = await requestService.GetAllRequestByCourseIdAsync(courseId);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetAllRequestByCourseIdAsync_ShouldReturnNull(string courseId)
        {
            var result = await requestService.GetAllRequestByCourseIdAsync(courseId);
            
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public async Task GetAllRequestsAsync()
        {
            var result = await requestService.GetAllRequestAsync();
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task Create_ShouldCreateRequestCorrectly()
        {
            var request = new CreateRequestModel()
            {
               TeacherId = "hugf73-3b3b-3b3b-3b3b-jb7ftyv",
                CourseId = "sjdiosi-9-3b3b-983b-3b3b-u7ws9nb3b3b3b",
                StudentId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                Status = RequestStatusEnum.Waiting.ToString()
            };
            await requestService.Create(request);
            var result = await requestService.GetAllRequestAsync();
            Assert.That(result.Count, Is.EqualTo(2));
           
        }

        [Test]
        [TestCase("Accepted","3wjjdiskj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task EditStatus_ShouldReturnTrue(string status, string requestId)
        {
            var result = await requestService.EditStatus( RequestStatusEnum.Accepted.ToString(),requestId);
            Assert.That(result, Is.True);
        }


        [Test]
        [TestCase("Rejected", " ")]
        [TestCase("Rejected", "something")]
        public async Task EditStatus_ShouldReturnFalse(string status, string requestId)
        {
            var result = await requestService.EditStatus(RequestStatusEnum.Accepted.ToString(), requestId);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b", "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetRequestStatusByStudentsIdAndCourseID(string studentId, string courseId)
        {
            var result = await requestService.GetRequestStatusByStudentsIdAndCourseID(studentId, courseId);
            Assert.That(result, Is.EqualTo(RequestStatusEnum.Accepted.ToString()));
        }

        [Test]
        [TestCase(" ", "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        [TestCase("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b", " ")]
        [TestCase("something", "something")]
        public async Task GetRequestStatusByStudentsIdAndCourseID_ShouldReturnNull(string studentId, string courseId)
        {
            var result = await requestService.GetRequestStatusByStudentsIdAndCourseID(studentId, courseId);
            Assert.That(result, Is.Null);
        }

    }
}
