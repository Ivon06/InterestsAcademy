using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestAcademy.Tests.UnitTests
{
    public class DbSeeder
    {
        public static void SeedDatabase(InterestsAcademyDbContext context)
        {
            SeedCourses(context);
            SeedRooms(context);
            SeedStudents(context);
            SeedTeachers(context);
            SeedUsers(context);
        }


        public static void SeedUsers(InterestsAcademyDbContext context)             
        {


            var admin = new User()
            {
                Id = "501889c2-7883-473b-9333-c55267249071",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                PhoneNumber = "0887654263",
                Name = "Админ",
                City = "Казанлък",
                Country = "България",
                Address = "ул.Възраждане 6 ет.2 ап.8",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("2005-05-20 11:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = null,
                IsActive = true
            };

            var student = new User()
            {
                Id = "bae65efa-6885-4144-9786-0719b0e2ebc4",
                UserName = "studentTest",
                NormalizedUserName = "STUDENTTEST",
                Email = "studentStudentov@abv.bg",
                NormalizedEmail = "STUDENTSTUDENTOV@ABV.BG",
                PhoneNumber = "0887654563",
                Name = "Студент Студентов",
                City = "Казанлък",
                Country = "България",
                Address = "ул.Възраждане 6 ет.2 ап.8",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("2007-06-10 11:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = null,
                IsActive = true
            };

            var teacher = new User()
            {
                Id = "28a172eb-6e0d-43ed-9a42-fb28025e1659",
                UserName = "teacherTest",
                NormalizedUserName = "TEACHERTEST",
                Email = "teacher@abv.bg",
                NormalizedEmail = "TEACHER@ABV.BG",
                PhoneNumber = "0887654560",
                Name = "Учител Учителов",
                City = "Казанлък",
                Country = "България",
                Address = "ул.Кокиче 14 ет.2 ап.8",
                Gender = GenderEnum.Мъж.ToString(),
                RegisteredOn = DateTime.UtcNow,
                BirthDate = DateTime.ParseExact("1988-02-08 11:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                ProfilePictureUrl = null,
                IsApproved = false,
                IsActive = true
            };



            context.Users.Add(admin);
            context.Users.Add(student);
            context.Users.Add(teacher);

        }

        public static void SeedStudents(InterestsAcademyDbContext context)
        {
            var student = new Student()
            {
                Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                UserId = "bae65efa-6885-4144-9786-0719b0e2ebc4"
            };
            context.Students.Add(student);
        }

        public static void SeedTeachers(InterestsAcademyDbContext context)
        {
            var teacher = new Teacher()
            {
                Id = "hugf73-3b3b-3b3b-3b3b-jb7ftyv",
                UserId = "28a172eb-6e0d-43ed-9a42-fb28025e1659"
            };
            context.Teachers.Add(teacher);
        }

        public static void SeedRooms(InterestsAcademyDbContext context)
        {
            var room1 = new Room()
            {
                Id = "gfcfgy-3b3b-hv77-3b3b-3b3b3b3b3b3b",
                Name = "Мултифункционална зала",
                Capacity = 26,
                Floor = 1

            };

            var room2 = new Room()
            {
                Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3c",
                Name = "Пространство \"Роботика и програмиране\"",
                Capacity = 26,
                Floor = 1
            };

            context.Rooms.Add(room1);
        }

        public static void SeedCourses(InterestsAcademyDbContext context)
        {
            var course1 = new Course()
            {
                Id = "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                Name = "Курс по роботика",
                Description = "Курс по роботика за начинаещи",
                TeacherId = "hugf73-3b3b-3b3b-3b3b-jb7ftyv",
                RoomId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3c",
                IsApproved = true,
                IsActive = true
            };

            context.Courses.Add(course1);
        }
    }
}
