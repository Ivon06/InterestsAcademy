using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class MaterialBaseAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GivenThings_Givers_GiverId",
                table: "GivenThings");

            migrationBuilder.DropTable(
                name: "CoursesGivers");

            migrationBuilder.DropTable(
                name: "RoomsGivers");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "123ac8bc-7d2f-4a21-93e5-e498b5fdb3f5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2597bdb5-47ba-4e1f-aa66-e008b8c8c2cc");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "26c53219-c861-4bbf-aa20-8b30e0ec732e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "56684c77-0a47-402f-873e-68baf07859c6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "66547a06-fbe9-43dc-af6f-19bfc14a85ab");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6f411190-24ed-4159-912e-1fdb049dee29");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7510347a-676e-4878-a2b1-5236f7ac3e28");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7ef9be3e-51ed-4d4e-90a1-9e452fc93b44");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7fcb7690-22c8-42ca-a69b-fc5567c47f2b");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "852643ff-939e-4d2d-b27c-58a3e0d6cdd6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "852d5e5c-bf47-4614-849b-99305b3dbc99");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "87e9b3c6-a53f-4687-8fb5-83c264556d3c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a1b65f7d-cda0-4184-a411-cc2343471268");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d92cd0b5-557b-4551-84e0-31a552f605a1");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e7762b5f-5837-43cb-97de-3b99b2029a85");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f23009a6-eee0-498d-9b49-c8fc126b0df7");

            migrationBuilder.AddColumn<string>(
                name: "MaterialItemId",
                table: "GivenThings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MaterialBaseItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeededQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialBaseItems", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GivenThings_MaterialItemId",
                table: "GivenThings",
                column: "MaterialItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_GivenThings_Givers_GiverId",
                table: "GivenThings",
                column: "GiverId",
                principalTable: "Givers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialItemId",
                table: "GivenThings",
                column: "MaterialItemId",
                principalTable: "MaterialBaseItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GivenThings_Givers_GiverId",
                table: "GivenThings");

            migrationBuilder.DropForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialItemId",
                table: "GivenThings");

            migrationBuilder.DropTable(
                name: "MaterialBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_GivenThings_MaterialItemId",
                table: "GivenThings");

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

            migrationBuilder.DropColumn(
                name: "MaterialItemId",
                table: "GivenThings");

            migrationBuilder.CreateTable(
                name: "CoursesGivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesGivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesGivers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoursesGivers_Givers_GiverId",
                        column: x => x.GiverId,
                        principalTable: "Givers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomsGivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsGivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomsGivers_Givers_GiverId",
                        column: x => x.GiverId,
                        principalTable: "Givers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomsGivers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "123ac8bc-7d2f-4a21-93e5-e498b5fdb3f5", 26, 1, "Конферентна зала" },
                    { "2597bdb5-47ba-4e1f-aa66-e008b8c8c2cc", 26, 1, "Библиотека" },
                    { "26c53219-c861-4bbf-aa20-8b30e0ec732e", 26, 1, "Еко стая" },
                    { "56684c77-0a47-402f-873e-68baf07859c6", 26, 1, "Физика и астрономия" },
                    { "66547a06-fbe9-43dc-af6f-19bfc14a85ab", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "6f411190-24ed-4159-912e-1fdb049dee29", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "7510347a-676e-4878-a2b1-5236f7ac3e28", 26, 1, "Физкултурен салон" },
                    { "7ef9be3e-51ed-4d4e-90a1-9e452fc93b44", 26, 1, "Мултифункционална зала" },
                    { "7fcb7690-22c8-42ca-a69b-fc5567c47f2b", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "852643ff-939e-4d2d-b27c-58a3e0d6cdd6", 26, 1, "Работилница" },
                    { "852d5e5c-bf47-4614-849b-99305b3dbc99", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "87e9b3c6-a53f-4687-8fb5-83c264556d3c", 26, 1, "Пространство за спорт на открито" },
                    { "a1b65f7d-cda0-4184-a411-cc2343471268", 26, 1, "Музикално студио" },
                    { "d92cd0b5-557b-4551-84e0-31a552f605a1", 26, 1, "Лаборатория" },
                    { "e7762b5f-5837-43cb-97de-3b99b2029a85", 26, 1, "Пространство за Археология" },
                    { "f23009a6-eee0-498d-9b49-c8fc126b0df7", 26, 1, "Градина за биоземеделие" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesGivers_CourseId",
                table: "CoursesGivers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesGivers_GiverId",
                table: "CoursesGivers",
                column: "GiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsGivers_GiverId",
                table: "RoomsGivers",
                column: "GiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsGivers_RoomId",
                table: "RoomsGivers",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_GivenThings_Givers_GiverId",
                table: "GivenThings",
                column: "GiverId",
                principalTable: "Givers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
