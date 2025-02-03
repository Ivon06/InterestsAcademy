using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78wijd768-7255-4iwf-9o23-6786yet54wa3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8duisjak-e8o7-8uu5-9c13-543e65731jh3", "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "835c8458-e8b7-493f-9c13-67bfcd7316a3", "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78374b9b-5158-4aff-8626-d088a02d79e1", "93418f37-da3b-4c78-b0ae-8f0022b09681" });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "09fb0433-8eb8-436a-b9d3-8fb63b03bc9c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "129bb432-fbbb-41eb-812a-5091978f7c7c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "19ee7987-e4ae-4af3-bc50-7fa27adcc4c8");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1b39e8a3-f267-4cb3-ba7a-6afc81249714");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1e81f8b2-a46b-498d-ae78-d7ced7775d1e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "38937a33-bffe-434f-bb3d-6fe6397e4538");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "64ae1f9e-bc59-4356-b74e-887f08425106");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "684c0183-d908-4b3e-8cc3-b2909f6ff92f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6863ab57-1613-43ab-9770-c301cd77f614");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6ec09e3b-ddd4-47ff-a3b6-6ad9278bfdb4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7e2f2252-bb8b-4716-a702-d891e77a7b4a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "89dcf285-c8e5-45b3-b5d3-19ad1818134f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c29aee18-f67c-4058-90dc-c2462832441a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c65aaef4-87ce-4e35-a60f-0b5d8f94171f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cc9a27d1-e7b6-48c8-9957-33ab64fe8b50");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cfdf8b3e-f216-4449-80c9-66e149c6c914");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "d9ef00ce-a909-4421-be44-3ef59927e5f6");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "2644afb5-f916-4b3f-b451-9ff86c881de3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78374b9b-5158-4aff-8626-d088a02d79e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835c8458-e8b7-493f-9c13-67bfcd7316a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8duisjak-e8o7-8uu5-9c13-543e65731jh3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78374b9b-5158-4aff-8626-d088a02d79e1", null, "Teacher", "TEACHER" },
                    { "78wijd768-7255-4iwf-9o23-6786yet54wa3", null, "Giver", "GIVER" },
                    { "835c8458-e8b7-493f-9c13-67bfcd7316a3", null, "Admin", "ADMIN" },
                    { "8duisjak-e8o7-8uu5-9c13-543e65731jh3", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "Gender", "IsActive", "IsApproved", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "RegisteredOn", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "080a469a-b5a2-44cc-a660-eea8e6fd05a5", 0, "ул. Ал. Стамболийски 30 ет.3 ап.11", new DateTime(2008, 4, 12, 13, 24, 0, 0, DateTimeKind.Unspecified), "Казанлък", "50de8a96-a60c-4509-a270-e2cd5436bfbc", "България", "petarpetrov@abv.bg", false, "Мъж", true, true, false, null, "Петър Петров", "PETARPETROV@ABV.BG", "PETAR", "AQAAAAIAAYagAAAAEGw78/Vg99afYMG7oDS0V8+0nJwVyx0Tb0msqSFlJY6uMDyQTFZs+JOEveENKInIHg==", "0885763826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697607303/projectImages/xbhwflepot9qpwmiiq6u.jpg", new DateTime(2025, 2, 2, 21, 50, 36, 604, DateTimeKind.Utc).AddTicks(5892), "1cbc7d8c-8423-4c72-884e-599875f64100", false, "petar" },
                    { "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8", 0, "ул. Незабравка 3", new DateTime(2015, 7, 18, 11, 20, 0, 0, DateTimeKind.Unspecified), "Енина", "bf258671-420e-4ba2-ba44-5d700503f5c8", "България", "admin@abv.bg", false, "Мъж", true, true, false, null, "Admin", "ADMIN@ABV.BG", "ADMIN", "AQAAAAIAAYagAAAAEIxzi8p+8pze8BJG5AixsJb8BFtFIOLFcPoJMDOyncX/C7uA+ku71RJ0IsUUizyyDA==", "0889864842", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697617373/projectImages/pyb6v86l6myou9h1sxca.jpg", new DateTime(2025, 2, 2, 21, 50, 36, 886, DateTimeKind.Utc).AddTicks(4172), "269006f4-7919-4624-90d3-8ad05c532689", false, "Admin" },
                    { "93418f37-da3b-4c78-b0ae-8f0022b09681", 0, "ул.Възраждане 6 ет.2 ап.8", new DateTime(1968, 2, 8, 11, 20, 0, 0, DateTimeKind.Unspecified), "Казанлък", "45dab1dc-eafc-4a0c-b18f-137383119084", "България", "georgidimitrov@abv.bg", false, "Мъж", true, true, false, null, "Георги Димитров", "GEORGIDIMITROV@ABV.BG", "GEORGI", "AQAAAAIAAYagAAAAEB6oUfG8aZvyknXkc4MZiVqNbGdA0/lzwHYCPELgQOJ7PszhUddEANKgeqWbslhNYw==", "0885789826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697608565/projectImages/mvorrsshjbw1e8bzfzgq.jpg", new DateTime(2025, 2, 2, 21, 50, 36, 753, DateTimeKind.Utc).AddTicks(9328), "5ad00d43-f22b-43bf-84d7-46011458ee17", false, "georgi" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "09fb0433-8eb8-436a-b9d3-8fb63b03bc9c", 26, 1, "Библиотека" },
                    { "129bb432-fbbb-41eb-812a-5091978f7c7c", 26, 1, "Мултифункционална зала" },
                    { "19ee7987-e4ae-4af3-bc50-7fa27adcc4c8", 26, 1, "Конферентна зала" },
                    { "1b39e8a3-f267-4cb3-ba7a-6afc81249714", 26, 1, "Еко стая" },
                    { "1e81f8b2-a46b-498d-ae78-d7ced7775d1e", 26, 1, "Градина за биоземеделие" },
                    { "38937a33-bffe-434f-bb3d-6fe6397e4538", 26, 1, "Физкултурен салон" },
                    { "64ae1f9e-bc59-4356-b74e-887f08425106", 26, 1, "Лаборатория" },
                    { "684c0183-d908-4b3e-8cc3-b2909f6ff92f", 26, 1, "Пространство за Археология" },
                    { "6863ab57-1613-43ab-9770-c301cd77f614", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "6ec09e3b-ddd4-47ff-a3b6-6ad9278bfdb4", 26, 1, "Работилница" },
                    { "7e2f2252-bb8b-4716-a702-d891e77a7b4a", 26, 1, "Пространство за спорт на открито" },
                    { "89dcf285-c8e5-45b3-b5d3-19ad1818134f", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "c29aee18-f67c-4058-90dc-c2462832441a", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "c65aaef4-87ce-4e35-a60f-0b5d8f94171f", 26, 1, "Музикално студио" },
                    { "cc9a27d1-e7b6-48c8-9957-33ab64fe8b50", 26, 1, "Физика и астрономия" },
                    { "cfdf8b3e-f216-4449-80c9-66e149c6c914", 26, 1, "Пространство \"Малки изследователи\"" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8duisjak-e8o7-8uu5-9c13-543e65731jh3", "080a469a-b5a2-44cc-a660-eea8e6fd05a5" },
                    { "835c8458-e8b7-493f-9c13-67bfcd7316a3", "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8" },
                    { "78374b9b-5158-4aff-8626-d088a02d79e1", "93418f37-da3b-4c78-b0ae-8f0022b09681" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "d9ef00ce-a909-4421-be44-3ef59927e5f6", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "2644afb5-f916-4b3f-b451-9ff86c881de3", "93418f37-da3b-4c78-b0ae-8f0022b09681" });
        }
    }
}
