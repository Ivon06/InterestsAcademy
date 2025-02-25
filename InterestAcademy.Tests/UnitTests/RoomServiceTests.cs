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
    [TestFixture]
    public class RoomServiceTests
    {
        private DbContextOptions<InterestsAcademyDbContext> dbOptions;
        private InterestsAcademyDbContext dbContext;
        private IRepository repo;
        private IRoomService roomService;


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

            roomService = new RoomService(repo);

        }

        [TearDown]
        public void TearDown()
        {

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();

        }

        [Test]
        
        public async Task GetAllRooms_ShouldWorkCorrectly()
        {
            var result = await roomService.GetAllRooms();
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        [TestCase("gfcfgy-3b3b-hv77-3b3b-3b3b3b3b3b3b")]
        public async Task IsRoomValid(string roomId)
        {
            var result = await roomService.IsRoomValid(roomId);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task IsRoomValid_ShouldReturnFalse(string roomId)
        {
            var result = await roomService.IsRoomValid(roomId);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b")]
        public async Task GetRoomIdByCourseId_ShouldWorkCorrectly(string courseId)
        {
            var result = await roomService.GetRoomIdByCourseId(courseId);
            Assert.That(result, Is.EqualTo("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3c"));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetRoomIdByCourseId_ShouldReturnNull(string courseId)
        {
            var result = await roomService.GetRoomIdByCourseId(courseId);
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        [TestCase("e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3c")]
        public async Task GetRoomNameByRoomId_ShouldWorkCorrectly(string roomId)
        {
            var result = await roomService.GetRoomNameByIdAsync(roomId);
            Assert.That(result, Is.EqualTo("Пространство \"Роботика и програмиране\""));
        }

        [Test]
        [TestCase("")]
        [TestCase("something")]
        public async Task GetRoomNameByRoomId_ShouldReturnNull(string roomId)
        {
            var result = await roomService.GetRoomNameByIdAsync(roomId);
            Assert.That(result, Is.EqualTo(""));
        }
    }
}
