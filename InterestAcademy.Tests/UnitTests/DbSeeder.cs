﻿using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

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
            SeedRequests(context);
            SeedStudentCourses(context);
            SeedRoles(context);
            SeedMaterialBaseItem(context);
            SeedGivenThings(context);
            SeedGroup(context);
            SeedUserGroups(context);

            context.SaveChanges();
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

            var teacher2 = new User()
            {
                Id = "hsu80-uq90d-43ed-9a42-fb28025e1659",
                UserName = "teacherTest2",
                NormalizedUserName = "TEACHERTEST2",
                Email = "teacher2@abv.bg",
                NormalizedEmail = "TEACHER2@ABV.BG",
                PhoneNumber = "0883554560",
                Name = "Учител2 Учителов",
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
            context.Users.Add(teacher2);

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
            context.Rooms.Add(room2);
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
                Duration = "2 месеца",
                IsApproved = true,
                IsActive = true,
                Category = "It",
            };

            var course2 = new Course()
            {
                Id = "sjdiosi-9-3b3b-983b-3b3b-u7ws9nb3b3b3b",
                Name = "Курс по кларинет",
                Description = "Курс по кларинет за начинаещи",
                TeacherId = "hugf73-3b3b-3b3b-3b3b-jb7ftyv",
                RoomId = "gfcfgy-3b3b-hv77-3b3b-3b3b3b3b3b3b",
                Duration = "2 месеца",
                IsApproved = true,
                IsActive = true,
                Category = "Art",
            };

            context.Courses.Add(course1);
            context.Courses.Add(course2);
        }

        public static void SeedRequests(InterestsAcademyDbContext context)
        {
            var request = new Request()
            {
                Id = "3wjjdiskj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                CourseId = "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                StudentId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                TeacherId = "hugf73-3b3b-3b3b-3b3b-jb7ftyv",
                Status = "Accepted"
            };
            context.Requests.Add(request);
        }

        public static void SeedStudentCourses(InterestsAcademyDbContext context)
        {
            var studentCourse = new StudentCourse()
            {
                StudentId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                CourseId = "enjcakbkj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                IsApproved = true
            };
            context.StudentsCourses.Add(studentCourse);
        }

        public static void SeedRoles(InterestsAcademyDbContext context)
        {
            var roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "78374b9b-5158-4aff-8626-d088a02d79e1",
                    Name = "Teacher",
                    NormalizedName = "TEACHER"

                },
                new IdentityRole()
                {
                    Id = "835c8458-e8b7-493f-9c13-67bfcd7316a3",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole()
                {
                    Id = "8duisjak-e8o7-8uu5-9c13-543e65731jh3" ,
                    Name = "Student",
                    NormalizedName = "STUDENT"
                }
            };
            context.Roles.AddRange(roles);
        }

        public static void SeedMaterialBaseItem(InterestsAcademyDbContext context)
        {
            var materialBaseItem = new MaterialBaseItem()
            {
                Id = "s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                Name = "Телескоп",
                NeededQuantity = 5,
                Category = DonationCategoryEnum.Physics.ToString()
            };

            var materialBaseItem2 = new MaterialBaseItem()
            {
                Id = "kai9-qj7-3b3b-983b-3b3b-3b3bsnb3b3b3c",
                Name = "Микроскоп",
                NeededQuantity = 4,
                Category = DonationCategoryEnum.Biology.ToString()
            };
            context.MaterialBaseItems.Add(materialBaseItem);
            context.MaterialBaseItems.Add(materialBaseItem2);
        }

        public static void SeedGivenThings(InterestsAcademyDbContext context)
        {
            var givenThing = new GivenThing()
            {
                Id = "72j-a9jd0-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                MaterialBaseItemId = "s78a-lqj7-3b3b-983b-3b3b-3b3bsnb3b3b3b",
                Quantity = 2,
                GiverEmail = "email@abv.bg",
                GiverName = "Иван Иванов",
                Name= "Телескоп",
                Category = DonationCategoryEnum.Physics.ToString()

            };
            var givenThing2 = new GivenThing()
            {
                Id = "ju8-7wy-is-b-3b3b-3b3bsnb3b3b3c",
                MaterialBaseItemId = "kai9-qj7-3b3b-983b-3b3b-3b3bsnb3b3b3c",
                Quantity = 1,
                GiverEmail = "email@abv.bg",
                GiverName = "Иван Иванов",
                Name = "Микроскоп",
                Category = DonationCategoryEnum.Biology.ToString()
            };
            context.GivenThings.Add(givenThing);
            context.GivenThings.Add(givenThing2);
        }

        public static void SeedUserGroups(InterestsAcademyDbContext context)
        {
            var userGroups = new List<UserGroup>()
            {
                new UserGroup()
                {
                    UserId = "28a172eb-6e0d-43ed-9a42-fb28025e1659",
                    GroupId = "bd0fd8e0-70ca-4475-9bef-d6ca66daefa1"
                },
                new UserGroup()
                {
                    UserId = "bae65efa-6885-4144-9786-0719b0e2ebc4",
                    GroupId = "bd0fd8e0-70ca-4475-9bef-d6ca66daefa1"
                }
            };

            context.UserGroups.AddRange(userGroups);
        }

        public static void SeedGroup(InterestsAcademyDbContext context)
        {
            var group = new Group()
            {
                Id = "bd0fd8e0-70ca-4475-9bef-d6ca66daefa1",
                Name = "testGroup"
            };

            context.Groups.Add(group);
        }
    }
}
