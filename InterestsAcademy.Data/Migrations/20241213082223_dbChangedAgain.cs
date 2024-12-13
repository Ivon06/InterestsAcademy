using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbChangedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "1f8b7b9a-87e2-4b28-be18-b16e9acb71b4", 26, 1, "Библиотека" },
                    { "38ada414-d686-4142-91c7-fe74e4387205", 26, 1, "Лаборатория" },
                    { "6a6e4f94-f478-4010-81e8-bfde17164472", 26, 1, "Градина за биоземеделие" },
                    { "751b65c7-8d08-4345-8531-3a3bc53454ab", 26, 1, "Физика и астрономия" },
                    { "7c767f33-34b2-47a8-9355-8e1d625f0600", 26, 1, "Физкултурен салон" },
                    { "8ab7c5c6-31dc-4d87-8098-83975c2ca9fc", 26, 1, "Музикално студио" },
                    { "9a9dc7f1-0d5c-47d0-8912-1509073fd7c6", 26, 1, "Еко стая" },
                    { "a65a665c-3171-4b5a-b2c3-0f5277070e61", 26, 1, "Пространство за Археология" },
                    { "c34a92a8-6fcd-4517-91c3-f83a58582b23", 26, 1, "Конферентна зала" },
                    { "d8080d86-dfd3-4c5a-8aee-d6a8f458b6d6", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "da02dbe9-7e41-4dcd-a50f-fadf30aa7663", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "dcd08d40-2246-4592-9372-9e8bae4ab6d4", 26, 1, "Работилница" },
                    { "ed709880-9b57-46b4-b59c-173f0082cde1", 26, 1, "Пространство за спорт на открито" },
                    { "f5c9a7bb-ff50-43e6-aeee-6a6ac3a11539", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "f664e6dc-755c-4e8f-96ea-52e39ec30fda", 26, 1, "Мултифункционална зала" },
                    { "f9b74efb-a9d1-47b4-86b5-2597cd01ed4e", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1f8b7b9a-87e2-4b28-be18-b16e9acb71b4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "38ada414-d686-4142-91c7-fe74e4387205");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6a6e4f94-f478-4010-81e8-bfde17164472");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "751b65c7-8d08-4345-8531-3a3bc53454ab");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7c767f33-34b2-47a8-9355-8e1d625f0600");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8ab7c5c6-31dc-4d87-8098-83975c2ca9fc");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9a9dc7f1-0d5c-47d0-8912-1509073fd7c6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a65a665c-3171-4b5a-b2c3-0f5277070e61");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c34a92a8-6fcd-4517-91c3-f83a58582b23");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d8080d86-dfd3-4c5a-8aee-d6a8f458b6d6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "da02dbe9-7e41-4dcd-a50f-fadf30aa7663");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "dcd08d40-2246-4592-9372-9e8bae4ab6d4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ed709880-9b57-46b4-b59c-173f0082cde1");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f5c9a7bb-ff50-43e6-aeee-6a6ac3a11539");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f664e6dc-755c-4e8f-96ea-52e39ec30fda");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f9b74efb-a9d1-47b4-86b5-2597cd01ed4e");

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
    }
}
