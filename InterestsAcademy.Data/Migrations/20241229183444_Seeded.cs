using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "080a469a-b5a2-44cc-a660-eea8e6fd05a5", 0, "ул. Ал. Стамболийски 30 ет.3 ап.11", new DateTime(2008, 4, 12, 13, 24, 0, 0, DateTimeKind.Unspecified), "Казанлък", "809e4eed-a11d-4b7e-885e-1e220f51cb9e", "България", "petarpetrov@abv.bg", false, "Мъж", true, true, false, null, "Петър Петров", "PETARPETROV@ABV.BG", "PETAR", "AQAAAAIAAYagAAAAEAePzVoO/18aqh27avg9fbr3Hs7ierEvYUs2gj7rqELkv+hLO34F4C+IdMpQdo4DcA==", "0885763826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697607303/projectImages/xbhwflepot9qpwmiiq6u.jpg", new DateTime(2024, 12, 29, 18, 34, 41, 85, DateTimeKind.Utc).AddTicks(6577), "ae466ddd-5f9a-45d9-93b7-688d44c8634f", false, "petar" },
                    { "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8", 0, "ул. Незабравка 3", new DateTime(2015, 7, 18, 11, 20, 0, 0, DateTimeKind.Unspecified), "Енина", "cbc0b86e-9cae-4475-b312-a2f96ae7f534", "България", "admin@abv.bg", false, "Мъж", true, true, false, null, "Admin", "ADMIN@ABV.BG", "ADMIN", "AQAAAAIAAYagAAAAEM/cwOkKfHnIOItfFuSpO0QR5rldljiXXwg9ecZvw8xdGl3FCqqcZKvU4fP8P6EEZA==", "0889864842", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697617373/projectImages/pyb6v86l6myou9h1sxca.jpg", new DateTime(2024, 12, 29, 18, 34, 41, 386, DateTimeKind.Utc).AddTicks(3429), "f5adf9d3-3950-4aa7-8742-3706655a53ae", false, "Admin" },
                    { "93418f37-da3b-4c78-b0ae-8f0022b09681", 0, "ул.Възраждане 6 ет.2 ап.8", new DateTime(1968, 2, 8, 11, 20, 0, 0, DateTimeKind.Unspecified), "Казанлък", "de41d9d9-4a7f-4f5b-aebf-4a235526f6ae", "България", "georgidimitrov@abv.bg", false, "Мъж", true, true, false, null, "Георги Димитров", "GEORGIDIMITROV@ABV.BG", "GEORGI", "AQAAAAIAAYagAAAAEODrv5FQIRhkzu/UyfsM7u4ekTWAGmSoKj3WDmGHDm/9KLCbl8PVnVFnU/VwvR0LjQ==", "0885789826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697608565/projectImages/mvorrsshjbw1e8bzfzgq.jpg", new DateTime(2024, 12, 29, 18, 34, 41, 235, DateTimeKind.Utc).AddTicks(6817), "7a4b375f-3af1-44f3-93d0-000eedb0ca2f", false, "georgi" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "073bc1a0-b492-4db8-92d8-25534c8a52e4", 26, 1, "Физкултурен салон" },
                    { "21619122-fc7e-41f2-8be9-c9ae0a196c21", 26, 1, "Пространство за спорт на открито" },
                    { "2bdd1682-b167-4057-ae77-a15ea422ba47", 26, 1, "Мултифункционална зала" },
                    { "3e16652d-7f14-42c7-a1fb-b4276c4d3941", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "48427f39-6dbb-4d58-9427-85f1e4b0bebe", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "49a8c556-aaeb-4b80-9090-e3bfcdc23e9a", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "6022ed45-fda1-4f4c-a3cf-f28c4be38b28", 26, 1, "Лаборатория" },
                    { "98a0ff52-fa85-490f-b1fa-b90103a7b886", 26, 1, "Градина за биоземеделие" },
                    { "bd8064ff-4442-42ac-ae3b-8f336af84539", 26, 1, "Музикално студио" },
                    { "c2d64628-975f-42a7-8a6a-46c1ee00a544", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "c82cecf7-388e-46ba-9d2b-e5f7d9952d93", 26, 1, "Работилница" },
                    { "ca54fa88-f95d-4f25-903d-c7d2d3e34be5", 26, 1, "Еко стая" },
                    { "cb10c7ed-4d60-4bcc-bbf4-1b90b63419b4", 26, 1, "Пространство за Археология" },
                    { "dde61614-5122-4e1b-8449-5519df4d123a", 26, 1, "Библиотека" },
                    { "e238df40-ae1c-477f-825a-153c5e633cde", 26, 1, "Конферентна зала" },
                    { "f30c2f4e-b166-4152-9c48-32c7eeabfff8", 26, 1, "Физика и астрономия" }
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
                values: new object[] { "87b24d15-e0c9-404d-98d3-5dc1237af7e7", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "9d8e089b-441b-4a7a-b98b-bcb4578ce49f", "93418f37-da3b-4c78-b0ae-8f0022b09681" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "073bc1a0-b492-4db8-92d8-25534c8a52e4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "21619122-fc7e-41f2-8be9-c9ae0a196c21");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2bdd1682-b167-4057-ae77-a15ea422ba47");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "3e16652d-7f14-42c7-a1fb-b4276c4d3941");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "48427f39-6dbb-4d58-9427-85f1e4b0bebe");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "49a8c556-aaeb-4b80-9090-e3bfcdc23e9a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6022ed45-fda1-4f4c-a3cf-f28c4be38b28");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "98a0ff52-fa85-490f-b1fa-b90103a7b886");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "bd8064ff-4442-42ac-ae3b-8f336af84539");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c2d64628-975f-42a7-8a6a-46c1ee00a544");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c82cecf7-388e-46ba-9d2b-e5f7d9952d93");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ca54fa88-f95d-4f25-903d-c7d2d3e34be5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cb10c7ed-4d60-4bcc-bbf4-1b90b63419b4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "dde61614-5122-4e1b-8449-5519df4d123a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e238df40-ae1c-477f-825a-153c5e633cde");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f30c2f4e-b166-4152-9c48-32c7eeabfff8");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "87b24d15-e0c9-404d-98d3-5dc1237af7e7");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9d8e089b-441b-4a7a-b98b-bcb4578ce49f");

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
    }
}
