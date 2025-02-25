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

namespace InterestAcademy.Tests.UnitTests
{
    [TestFixture]
    public class CourseServiceTests
    {

        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private ICourseService courseService;
        private Mock<IRoomService> roomServiceMock;
        private Mock<IRequestService> requestServiceMock;

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
            requestServiceMock = new Mock<IRequestService>();
            roomServiceMock = new Mock<IRoomService>();

            courseService = new CourseService(repo,requestServiceMock.Object,roomServiceMock.Object);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

    }
}
