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

namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class TeacherServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private ITeacherService teacherService;
        private Mock<IRepository> repoMock;

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
            repoMock = new Mock<IRepository>();
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


    }
}
