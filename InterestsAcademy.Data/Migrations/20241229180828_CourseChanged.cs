using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class CourseChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78374b9b-5158-4aff-8626-d088a02d79e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78wijd768-7255-4iwf-9o23-6786yet54wa3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835c8458-e8b7-493f-9c13-67bfcd7316a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8duisjak-e8o7-8uu5-9c13-543e65731jh3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "123dce05-3b28-4c49-b83c-c43b99255e1a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1e848d10-6435-41bc-a5b6-dee9a24e379e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "27241b7a-9110-40fd-9e37-d6e176b16e00");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2b739957-8d9e-4319-a43a-bb8c30d8d09d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "487f1e23-ebf4-4e35-8091-e8adfcece0c7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4934c67b-108e-494a-b095-4a2983681a9e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "592eb7ac-1ee3-4557-a91b-898b9d28662d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "5fe1dc94-4043-4ed0-a774-0c9ea6d45a67");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6a373037-d2f5-451e-ab01-041dcc2a4ffb");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6deee4c4-995b-46f3-96ec-c50cd370b645");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7ec13306-e45e-486a-b997-2cbb1d5713aa");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8b12c53b-adcd-43db-a42d-8c4cb44478db");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9a9267aa-834c-446f-a52e-681b5b49d106");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a5f535c9-51ca-4393-b1f0-1cad4d2945da");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d2aab234-dcd6-4fd0-b197-f0a9efae11a3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e5804f48-5471-4d29-893b-367a99ff0042");
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
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "123dce05-3b28-4c49-b83c-c43b99255e1a", 26, 1, "Еко стая" },
                    { "1e848d10-6435-41bc-a5b6-dee9a24e379e", 26, 1, "Пространство за спорт на открито" },
                    { "27241b7a-9110-40fd-9e37-d6e176b16e00", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "2b739957-8d9e-4319-a43a-bb8c30d8d09d", 26, 1, "Музикално студио" },
                    { "487f1e23-ebf4-4e35-8091-e8adfcece0c7", 26, 1, "Физика и астрономия" },
                    { "4934c67b-108e-494a-b095-4a2983681a9e", 26, 1, "Мултифункционална зала" },
                    { "592eb7ac-1ee3-4557-a91b-898b9d28662d", 26, 1, "Библиотека" },
                    { "5fe1dc94-4043-4ed0-a774-0c9ea6d45a67", 26, 1, "Конферентна зала" },
                    { "6a373037-d2f5-451e-ab01-041dcc2a4ffb", 26, 1, "Работилница" },
                    { "6deee4c4-995b-46f3-96ec-c50cd370b645", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "7ec13306-e45e-486a-b997-2cbb1d5713aa", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "8b12c53b-adcd-43db-a42d-8c4cb44478db", 26, 1, "Градина за биоземеделие" },
                    { "9a9267aa-834c-446f-a52e-681b5b49d106", 26, 1, "Лаборатория" },
                    { "a5f535c9-51ca-4393-b1f0-1cad4d2945da", 26, 1, "Пространство за Археология" },
                    { "d2aab234-dcd6-4fd0-b197-f0a9efae11a3", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "e5804f48-5471-4d29-893b-367a99ff0042", 26, 1, "Физкултурен салон" }
                });
        }
    }
}
