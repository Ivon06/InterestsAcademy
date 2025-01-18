using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsActiveForCourseAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0536e904-8b3b-4cd6-857d-5772574dd662");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0873964e-5c9d-4562-8f3b-37bff2757983");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "107c998d-3867-4c7c-8ada-5af8f2303070");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "10923716-fb08-422c-9191-02f9eb359e40");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1532bb2d-f143-4790-b7aa-a8bb514231d3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2b02b161-ec2c-4f0e-8a62-21d0fb7ebf83");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "32c2b204-fe14-4b43-9132-bde27128788c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "41949c56-21e2-4603-a767-a07161a546b6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "5269b829-c07b-4592-b5a0-809a5a2cd581");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "573166cf-2e17-4135-aeae-9519c6607df7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7409ab1a-cbcf-4c1e-a2a8-cb5ed9c700df");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7d0b2998-b638-4e2d-9f6c-91ab0c82f5c7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8bd9b144-a7ca-4ba1-8e0f-1aea190e2ba5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c61e37ef-d1e8-42a8-9792-84fb00e6c12c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d5174b57-ecb8-446a-8561-cc43c2b953b6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f53e628f-3466-48a3-ad58-b888c738e12e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "830dc34a-8450-4914-8981-0798360c5c6b");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "67227ca9-9fa8-4534-99c2-06210742f0ff");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "bf5d5bb8-7c8e-415c-9184-d9999e290604", "AQAAAAIAAYagAAAAECCV9gV3HPM6Owc7oOu8ZwGsgpDpWPLcCeq2VCgKeCwLmMkHU4zdVJaSp1hXxj6AxA==", new DateTime(2025, 1, 17, 10, 22, 4, 134, DateTimeKind.Utc).AddTicks(3000), "7784dc11-7f64-40fe-9e0a-2f10be58f188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "459e9bad-3178-4bdf-92ac-d7fb7652498a", "AQAAAAIAAYagAAAAEF1mSFRIh8/J5ezbEV+KdZGyodaC9xRFHu6xAu6FW3P4DngdhHnl/aY0nrJoSdeKBg==", new DateTime(2025, 1, 17, 10, 22, 4, 305, DateTimeKind.Utc).AddTicks(8505), "f8c2ef1f-67b2-4162-bb95-c8f36dfb373a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "efcf8418-afd6-4123-a495-07f72a11d41c", "AQAAAAIAAYagAAAAECw5rDYPNlwd/ad+nNcHk7Fq6nwWRqzA5DicQmx+bMUaZHgbw5FPB7LEa89pFcGjvQ==", new DateTime(2025, 1, 17, 10, 22, 4, 203, DateTimeKind.Utc).AddTicks(5621), "c5d58eb0-5578-487e-9caf-59d01dc2cff2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "01e9c2db-9035-4071-8602-f7b768b5a47d", 26, 1, "Пространство за спорт на открито" },
                    { "1e6cebba-b4e6-48a4-ae32-6336b9bda35e", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "1f4dc64a-8d58-44a6-a1f9-0d8a49413be6", 26, 1, "Физика и астрономия" },
                    { "20b34164-715a-42bd-8963-1f5b786c38d3", 26, 1, "Пространство за Археология" },
                    { "2904ecee-5398-4049-8118-929a50437514", 26, 1, "Конферентна зала" },
                    { "6e0f6e88-fcc6-4312-b0be-38eb715c9f1f", 26, 1, "Градина за биоземеделие" },
                    { "8ab44d36-a00e-4e39-ac9e-4d863cd159a7", 26, 1, "Лаборатория" },
                    { "8fd131ed-da38-427f-9e06-a775666e0000", 26, 1, "Мултифункционална зала" },
                    { "93113b4a-8598-4815-b318-e1c5f5e7f077", 26, 1, "Библиотека" },
                    { "a6bd87fc-9459-4a2b-ac15-426069b0c975", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "b079cae6-1b63-4753-8c53-4acfa9822797", 26, 1, "Музикално студио" },
                    { "b182b4af-47a3-4d82-a917-dfb78d4a04bf", 26, 1, "Физкултурен салон" },
                    { "cb83907a-893e-49ab-b680-63cca2e408b5", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "d46e79e7-3875-4e83-b274-9430002d435a", 26, 1, "Работилница" },
                    { "f87467af-c6e0-4af1-8e05-390f31f4a35d", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "fea5e2d5-6854-42df-b7e2-e3d9fa34cf56", 26, 1, "Еко стая" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "2436e6ba-7163-4c01-b6d1-c4ead64ec7c0", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "69d01633-b6d0-410b-b135-3442eef1f8ce", "93418f37-da3b-4c78-b0ae-8f0022b09681" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "01e9c2db-9035-4071-8602-f7b768b5a47d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1e6cebba-b4e6-48a4-ae32-6336b9bda35e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1f4dc64a-8d58-44a6-a1f9-0d8a49413be6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "20b34164-715a-42bd-8963-1f5b786c38d3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2904ecee-5398-4049-8118-929a50437514");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6e0f6e88-fcc6-4312-b0be-38eb715c9f1f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8ab44d36-a00e-4e39-ac9e-4d863cd159a7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8fd131ed-da38-427f-9e06-a775666e0000");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "93113b4a-8598-4815-b318-e1c5f5e7f077");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a6bd87fc-9459-4a2b-ac15-426069b0c975");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b079cae6-1b63-4753-8c53-4acfa9822797");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b182b4af-47a3-4d82-a917-dfb78d4a04bf");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cb83907a-893e-49ab-b680-63cca2e408b5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d46e79e7-3875-4e83-b274-9430002d435a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f87467af-c6e0-4af1-8e05-390f31f4a35d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "fea5e2d5-6854-42df-b7e2-e3d9fa34cf56");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2436e6ba-7163-4c01-b6d1-c4ead64ec7c0");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "69d01633-b6d0-410b-b135-3442eef1f8ce");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b74730d4-c379-4980-a99f-138b64a4a3f3", "AQAAAAIAAYagAAAAENsdt+M9AuI0QFTZLn9icJt87dRs/5rI+wrrYBqPHe2XH3T84O9L5ptA1mLw5K5FxA==", new DateTime(2025, 1, 3, 20, 11, 45, 300, DateTimeKind.Utc).AddTicks(8313), "ddb95364-64d4-40a4-99a4-ef2157b428ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6d3125e0-0e6f-49d2-9379-d4822ee4e3cb", "AQAAAAIAAYagAAAAEN5Pqqu5lkbQGLormFPR+ROQCUhRABxZlQYmdkSIOBGiq/uU1o1jWI1Ix3HngybvyQ==", new DateTime(2025, 1, 3, 20, 11, 45, 612, DateTimeKind.Utc).AddTicks(2071), "c0cfd465-de06-4075-ab2f-ea50d71e9ebc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "65114805-8d04-43bb-888b-738689c4a25a", "AQAAAAIAAYagAAAAEKoMQLmlQu3aKdYNGw8cSLj2MNElYAyQDlnXY6QhM0CNXe9dDSdzyuCmimTKcbBx8A==", new DateTime(2025, 1, 3, 20, 11, 45, 450, DateTimeKind.Utc).AddTicks(5438), "a552d5c9-ccd6-47f6-915b-9ae56a37d363" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "0536e904-8b3b-4cd6-857d-5772574dd662", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "0873964e-5c9d-4562-8f3b-37bff2757983", 26, 1, "Библиотека" },
                    { "107c998d-3867-4c7c-8ada-5af8f2303070", 26, 1, "Еко стая" },
                    { "10923716-fb08-422c-9191-02f9eb359e40", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "1532bb2d-f143-4790-b7aa-a8bb514231d3", 26, 1, "Градина за биоземеделие" },
                    { "2b02b161-ec2c-4f0e-8a62-21d0fb7ebf83", 26, 1, "Музикално студио" },
                    { "32c2b204-fe14-4b43-9132-bde27128788c", 26, 1, "Пространство за Археология" },
                    { "41949c56-21e2-4603-a767-a07161a546b6", 26, 1, "Физкултурен салон" },
                    { "5269b829-c07b-4592-b5a0-809a5a2cd581", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "573166cf-2e17-4135-aeae-9519c6607df7", 26, 1, "Пространство за спорт на открито" },
                    { "7409ab1a-cbcf-4c1e-a2a8-cb5ed9c700df", 26, 1, "Работилница" },
                    { "7d0b2998-b638-4e2d-9f6c-91ab0c82f5c7", 26, 1, "Конферентна зала" },
                    { "8bd9b144-a7ca-4ba1-8e0f-1aea190e2ba5", 26, 1, "Мултифункционална зала" },
                    { "c61e37ef-d1e8-42a8-9792-84fb00e6c12c", 26, 1, "Лаборатория" },
                    { "d5174b57-ecb8-446a-8561-cc43c2b953b6", 26, 1, "Физика и астрономия" },
                    { "f53e628f-3466-48a3-ad58-b888c738e12e", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "830dc34a-8450-4914-8981-0798360c5c6b", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "67227ca9-9fa8-4534-99c2-06210742f0ff", "93418f37-da3b-4c78-b0ae-8f0022b09681" });
        }
    }
}
