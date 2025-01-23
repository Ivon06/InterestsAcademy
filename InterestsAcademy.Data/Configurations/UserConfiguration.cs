using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(GetUsers());
        }

        private List<User> GetUsers()
        {
            var users = new List<User>();
            var passwordHasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                UserName = "petar",
                NormalizedUserName = "PETAR",
                Email = "petarpetrov@abv.bg",
                NormalizedEmail = "PETARPETROV@ABV.BG",
                PhoneNumber = "0885763826",
                Name = "Петър Петров",
                City = "Казанлък",
                Country = "България",
                Address = "ул. Ал. Стамболийски 30 ет.3 ап.11",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("2008-04-12 13:24", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1697607303/projectImages/xbhwflepot9qpwmiiq6u.jpg"
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "123456");
            users.Add(user);


            var user2 = new User()
            {
                Id = "93418f37-da3b-4c78-b0ae-8f0022b09681",
                UserName = "georgi",
                NormalizedUserName = "GEORGI",
                Email = "georgidimitrov@abv.bg",
                NormalizedEmail = "GEORGIDIMITROV@ABV.BG",
                PhoneNumber = "0885789826",
                Name = "Георги Димитров",
                City = "Казанлък",
                Country = "България",
                Address = "ул.Възраждане 6 ет.2 ап.8",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("1968-02-08 11:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1697608565/projectImages/mvorrsshjbw1e8bzfzgq.jpg"
            };

            user2.PasswordHash = passwordHasher.HashPassword(user2, "3456789");
            users.Add(user2);

         

            var user3 = new User()
            {
                Id = "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                PhoneNumber = "0889864842",
                Name = "Admin",
                City = "Енина",
                Country = "България",
                Address = "ул. Незабравка 3",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("2015-07-18 11:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1697617373/projectImages/pyb6v86l6myou9h1sxca.jpg"
            };

            user3.PasswordHash = passwordHasher.HashPassword(user3, "admin123");

            users.Add(user3);


            return users;
        }
    }
}
