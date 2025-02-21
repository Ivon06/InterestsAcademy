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
    }
}
