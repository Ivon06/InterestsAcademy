using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbChangedCourseTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "07cf49a7-7218-4d30-ae67-07c24b9c8805");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0bd3511d-7db9-4df3-847f-21db3eb5a9a8");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "377b7730-fe65-4605-a6c3-18afdcc178e1");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "3a9ee2dd-9393-4351-a99b-aa7e5ca0d5b0");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "47aa8011-1e14-409a-966e-25fe20c047f4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4cee95f3-3f2e-4102-96bd-c856030f64cd");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4d193774-cb64-48ee-bd9f-76088b4be0bc");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4db27211-f4db-4f80-b079-e74167cebc80");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4e6b9292-22a2-4e53-813b-6e3faec619d3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "714c0da5-1e1a-4eab-aae5-c7679f412148");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "789dd0b0-9a38-4d33-9cd1-61b23adeed31");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9559c3c2-1ab0-40dc-b84a-1baf463295e4");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cb0b7614-4e72-4f6e-99a8-e58c1b7464b5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cdd178a6-e84e-4227-8cdf-84b76a4fad2e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d21f5ca2-8346-49b2-8b1c-8333bf43a573");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f28794c3-4c68-4a3c-accf-b18ed37d96a9");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "0fc558dc-be45-45b6-9d20-af9746a8e350", 26, 1, "Мултифункционална зала" },
                    { "13c76586-6e41-4ac2-81de-58f5b483e375", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "140655f1-25a0-4047-ae8f-0e5f04f51aa7", 26, 1, "Пространство за спорт на открито" },
                    { "2b011bdd-281b-47c4-95d4-7991cade4ca6", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "49cc333e-446a-442a-90c2-a55d526d9330", 26, 1, "Библиотека" },
                    { "4c877e9f-d8d9-460b-aaa9-e58942534b62", 26, 1, "Градина за биоземеделие" },
                    { "5fbb1f90-dff9-4ba7-b5cb-dfd0284057cf", 26, 1, "Пространство за Археология" },
                    { "67f8302a-9a62-440e-8865-82cb7578435d", 26, 1, "Музикално студио" },
                    { "6d1750ae-b1ee-431e-8c7a-49d300880165", 26, 1, "Работилница" },
                    { "8a531e6b-4761-4e44-aec1-8388c34b9928", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "8c825eff-fbed-4357-9cd1-0d04ae8354d5", 26, 1, "Конферентна зала" },
                    { "90e417c9-af84-4933-bcd0-4d6d4a25c4a8", 26, 1, "Еко стая" },
                    { "a44479ac-f9f1-4864-b9f9-3bfb9cf3c357", 26, 1, "Физика и астрономия" },
                    { "b3864226-886f-4284-8fb3-ba24515e6b66", 26, 1, "Физкултурен салон" },
                    { "b87c8bee-597d-431e-897e-4e94a3b7c625", 26, 1, "Лаборатория" },
                    { "f99fd0d2-f7ca-488f-911c-dd39096dbb01", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0fc558dc-be45-45b6-9d20-af9746a8e350");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "13c76586-6e41-4ac2-81de-58f5b483e375");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "140655f1-25a0-4047-ae8f-0e5f04f51aa7");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2b011bdd-281b-47c4-95d4-7991cade4ca6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "49cc333e-446a-442a-90c2-a55d526d9330");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4c877e9f-d8d9-460b-aaa9-e58942534b62");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "5fbb1f90-dff9-4ba7-b5cb-dfd0284057cf");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "67f8302a-9a62-440e-8865-82cb7578435d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "6d1750ae-b1ee-431e-8c7a-49d300880165");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8a531e6b-4761-4e44-aec1-8388c34b9928");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8c825eff-fbed-4357-9cd1-0d04ae8354d5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "90e417c9-af84-4933-bcd0-4d6d4a25c4a8");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a44479ac-f9f1-4864-b9f9-3bfb9cf3c357");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b3864226-886f-4284-8fb3-ba24515e6b66");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b87c8bee-597d-431e-897e-4e94a3b7c625");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f99fd0d2-f7ca-488f-911c-dd39096dbb01");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "07cf49a7-7218-4d30-ae67-07c24b9c8805", 26, 1, "Библиотека" },
                    { "0bd3511d-7db9-4df3-847f-21db3eb5a9a8", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "377b7730-fe65-4605-a6c3-18afdcc178e1", 26, 1, "Лаборатория" },
                    { "3a9ee2dd-9393-4351-a99b-aa7e5ca0d5b0", 26, 1, "Физкултурен салон" },
                    { "47aa8011-1e14-409a-966e-25fe20c047f4", 26, 1, "Пространство за Археология" },
                    { "4cee95f3-3f2e-4102-96bd-c856030f64cd", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "4d193774-cb64-48ee-bd9f-76088b4be0bc", 26, 1, "Мултифункционална зала" },
                    { "4db27211-f4db-4f80-b079-e74167cebc80", 26, 1, "Еко стая" },
                    { "4e6b9292-22a2-4e53-813b-6e3faec619d3", 26, 1, "Конферентна зала" },
                    { "714c0da5-1e1a-4eab-aae5-c7679f412148", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "789dd0b0-9a38-4d33-9cd1-61b23adeed31", 26, 1, "Пространство за спорт на открито" },
                    { "9559c3c2-1ab0-40dc-b84a-1baf463295e4", 26, 1, "Градина за биоземеделие" },
                    { "cb0b7614-4e72-4f6e-99a8-e58c1b7464b5", 26, 1, "Работилница" },
                    { "cdd178a6-e84e-4227-8cdf-84b76a4fad2e", 26, 1, "Музикално студио" },
                    { "d21f5ca2-8346-49b2-8b1c-8333bf43a573", 26, 1, "Физика и астрономия" },
                    { "f28794c3-4c68-4a3c-accf-b18ed37d96a9", 26, 1, "Младежки клуб по видеозаснемане" }
                });
        }
    }
}
