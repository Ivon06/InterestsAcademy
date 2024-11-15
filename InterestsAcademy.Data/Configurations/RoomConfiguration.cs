using InterestsAcademy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {

        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(GetRooms());
        }

        private IEnumerable<Room> GetRooms()
        {
            List<Room> rooms = new List<Room>()
            {
                new Room()
                {
                    Name = "Мултифункционална зала",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Музикално студио",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Пространство \"Малки изследователи\"",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Работилница",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Физкултурен салон",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Конферентна зала",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Библиотека",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Физика и астрономия",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Пространство \"Роботика и програмиране\"",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Пространство за Археология",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Лаборатория",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Младежки клуб по видеозаснемане",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Пространство за спорт на открито",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Еко стая",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Градина за биоземеделие",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Name = "Дейности извън Академията - ориентиране в планината, конна езда, походи",
                    Capacity = 26,
                    Floor = 1
                }
                };

            return rooms;
        }
    }
}
