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
                    Id = "129bb432-fbbb-41eb-812a-5091978f7c7c",
                    Name = "Мултифункционална зала",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "c65aaef4-87ce-4e35-a60f-0b5d8f94171f",
                    Name = "Музикално студио",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "cfdf8b3e-f216-4449-80c9-66e149c6c914",
                    Name = "Пространство \"Малки изследователи\"",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "6ec09e3b-ddd4-47ff-a3b6-6ad9278bfdb4",
                    Name = "Работилница",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id="38937a33-bffe-434f-bb3d-6fe6397e4538",
                    Name = "Физкултурен салон",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "19ee7987-e4ae-4af3-bc50-7fa27adcc4c8",
                    Name = "Конферентна зала",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "09fb0433-8eb8-436a-b9d3-8fb63b03bc9c",
                    Name = "Библиотека",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "cc9a27d1-e7b6-48c8-9957-33ab64fe8b50",
                    Name = "Физика и астрономия",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "c29aee18-f67c-4058-90dc-c2462832441a",
                    Name = "Пространство \"Роботика и програмиране\"",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "684c0183-d908-4b3e-8cc3-b2909f6ff92f",
                    Name = "Пространство за Археология",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "64ae1f9e-bc59-4356-b74e-887f08425106",
                    Name = "Лаборатория",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "89dcf285-c8e5-45b3-b5d3-19ad1818134f",
                    Name = "Младежки клуб по видеозаснемане",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "7e2f2252-bb8b-4716-a702-d891e77a7b4a",
                    Name = "Пространство за спорт на открито",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "1b39e8a3-f267-4cb3-ba7a-6afc81249714",
                    Name = "Еко стая",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "1e81f8b2-a46b-498d-ae78-d7ced7775d1e",
                    Name = "Градина за биоземеделие",
                    Capacity = 26,
                    Floor = 1
                },
                new Room()
                {
                    Id = "6863ab57-1613-43ab-9770-c301cd77f614",
                    Name = "Дейности извън Академията - ориентиране в планината, конна езда, походи",
                    Capacity = 26,
                    Floor = 1
                }
                };

            return rooms;
        }
    }
}
