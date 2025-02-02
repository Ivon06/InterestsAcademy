using InterestsAcademy.Core.Models.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IRoomService
    {
        Task<List<RoomViewModel>> GetAllRooms();
        Task<bool> IsRoomValid(string roomId);
    }
}
