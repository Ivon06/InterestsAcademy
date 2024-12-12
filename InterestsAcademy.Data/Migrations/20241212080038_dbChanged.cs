using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1c3240ca-c420-4ab9-b538-ee838f0a48f3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4c976139-fac5-4130-b713-0b498e5b06de");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "558daacd-8bc6-46b4-9c7e-fb3cab093863");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "5c4183c4-96ff-481a-8c37-623802130358");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "650a7eb7-50ef-4534-b446-d840a748d3c2");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "68c12d14-c0b8-4d69-b9d7-600fc6e5b317");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8fc9a360-a60e-4fd5-9650-1e6a4763eb26");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9b0c50a9-c92b-4c52-a4d1-8fb63ad9005c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a0de5aa2-63a6-4342-97a1-ddb9765bc741");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "abfd2d0f-c11c-4993-8f22-2590f720b1cb");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ac4c7163-a8f6-4e75-9324-c426ace4525d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b6145050-881b-4886-a0c7-deb8f02f33cc");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b9ffae41-6ecc-478d-9ccf-acce974f7e27");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "be17055f-7527-4798-94cb-7f3c8b1e770c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e78f649f-79ba-4a8f-97b3-4bae018ca770");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f2516ee3-78ab-4901-8918-b332a59c3e5a");

            migrationBuilder.AddColumn<string>(
                name: "GiverType",
                table: "Givers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "0584b896-2060-4a8c-a70e-eda8a59ed419", 26, 1, "Пространство за Археология" },
                    { "0c879ffa-84e1-4826-b038-f0c9521bf399", 26, 1, "Музикално студио" },
                    { "32bd46e3-a50c-4603-b0b5-3b64e8dd5838", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "35a06a24-278b-495e-a618-08a2187e362f", 26, 1, "Мултифункционална зала" },
                    { "39bb25ce-93b7-49f9-88b2-a5ca27c05588", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "73b12fe1-2749-4568-a05e-809438363506", 26, 1, "Еко стая" },
                    { "760c58e9-8194-4e07-8d58-7cfcc001e672", 26, 1, "Пространство за спорт на открито" },
                    { "857dc4f6-dd38-4017-b041-0db5ba002b6d", 26, 1, "Лаборатория" },
                    { "86aaf621-8a40-42cd-a831-244af3a3ade7", 26, 1, "Конферентна зала" },
                    { "878e07c0-c175-4a55-a988-98b6581357bd", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "89953923-435b-46ec-822b-208dc409ede0", 26, 1, "Градина за биоземеделие" },
                    { "c372b47d-0b99-4d66-91dc-4f23346575dd", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "c5ba3d73-ec59-45c1-9376-762dfa23b3dd", 26, 1, "Физкултурен салон" },
                    { "df0b5ade-2ca9-4c20-a577-761feafbc9df", 26, 1, "Библиотека" },
                    { "e7f65bbb-1f9a-4f2a-a5ac-306b2ba89b77", 26, 1, "Работилница" },
                    { "fb0ef99d-00b4-4c3c-9d81-206b53a0bec1", 26, 1, "Физика и астрономия" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0584b896-2060-4a8c-a70e-eda8a59ed419");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0c879ffa-84e1-4826-b038-f0c9521bf399");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "32bd46e3-a50c-4603-b0b5-3b64e8dd5838");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "35a06a24-278b-495e-a618-08a2187e362f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "39bb25ce-93b7-49f9-88b2-a5ca27c05588");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "73b12fe1-2749-4568-a05e-809438363506");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "760c58e9-8194-4e07-8d58-7cfcc001e672");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "857dc4f6-dd38-4017-b041-0db5ba002b6d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "86aaf621-8a40-42cd-a831-244af3a3ade7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "878e07c0-c175-4a55-a988-98b6581357bd");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "89953923-435b-46ec-822b-208dc409ede0");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c372b47d-0b99-4d66-91dc-4f23346575dd");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c5ba3d73-ec59-45c1-9376-762dfa23b3dd");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "df0b5ade-2ca9-4c20-a577-761feafbc9df");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e7f65bbb-1f9a-4f2a-a5ac-306b2ba89b77");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "fb0ef99d-00b4-4c3c-9d81-206b53a0bec1");

            migrationBuilder.DropColumn(
                name: "GiverType",
                table: "Givers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "1c3240ca-c420-4ab9-b538-ee838f0a48f3", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "4c976139-fac5-4130-b713-0b498e5b06de", 26, 1, "Лаборатория" },
                    { "558daacd-8bc6-46b4-9c7e-fb3cab093863", 26, 1, "Пространство за Археология" },
                    { "5c4183c4-96ff-481a-8c37-623802130358", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "650a7eb7-50ef-4534-b446-d840a748d3c2", 26, 1, "Физика и астрономия" },
                    { "68c12d14-c0b8-4d69-b9d7-600fc6e5b317", 26, 1, "Музикално студио" },
                    { "8fc9a360-a60e-4fd5-9650-1e6a4763eb26", 26, 1, "Градина за биоземеделие" },
                    { "9b0c50a9-c92b-4c52-a4d1-8fb63ad9005c", 26, 1, "Библиотека" },
                    { "a0de5aa2-63a6-4342-97a1-ddb9765bc741", 26, 1, "Работилница" },
                    { "abfd2d0f-c11c-4993-8f22-2590f720b1cb", 26, 1, "Еко стая" },
                    { "ac4c7163-a8f6-4e75-9324-c426ace4525d", 26, 1, "Пространство за спорт на открито" },
                    { "b6145050-881b-4886-a0c7-deb8f02f33cc", 26, 1, "Мултифункционална зала" },
                    { "b9ffae41-6ecc-478d-9ccf-acce974f7e27", 26, 1, "Физкултурен салон" },
                    { "be17055f-7527-4798-94cb-7f3c8b1e770c", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "e78f649f-79ba-4a8f-97b3-4bae018ca770", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "f2516ee3-78ab-4901-8918-b332a59c3e5a", 26, 1, "Конферентна зала" }
                });
        }
    }
}
