using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
