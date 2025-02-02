using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Room;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository repo;

        public RoomService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<RoomViewModel>> GetAllRooms()
        {
            var result = await repo.GetAll<Room>()
                .Select(r => new RoomViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                })
                .ToListAsync();

            return result;
        }

        public async Task<bool> IsRoomValid(string roomId)
        {
            var room = await repo.GetByIdAsync<Room>(roomId);

            return room == null ? false : true;
        }
    }
}
