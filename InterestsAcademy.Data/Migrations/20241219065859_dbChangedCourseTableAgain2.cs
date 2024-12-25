using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbChangedCourseTableAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "0f482e43-9502-4121-929e-283cb181cd73", 26, 1, "Конферентна зала" },
                    { "13b3f872-9c6a-43e7-9674-b959d32758b3", 26, 1, "Пространство за спорт на открито" },
                    { "39642982-b7ab-4fbf-8f63-953c5929f8fe", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "3b6590eb-eafb-4f60-86ff-18105c033744", 26, 1, "Библиотека" },
                    { "3e7ccb16-fa6f-4dca-bfd9-63103c9dc3ec", 26, 1, "Мултифункционална зала" },
                    { "3f193828-eabc-4c3b-8263-6f88790d9a2f", 26, 1, "Пространство за Археология" },
                    { "5495e880-8d38-4868-8028-82f298527c56", 26, 1, "Еко стая" },
                    { "691095f3-5f56-4dec-8f75-fbe7b9ab7cae", 26, 1, "Музикално студио" },
                    { "73072807-6997-460f-85b2-b646293e2f1e", 26, 1, "Лаборатория" },
                    { "78def21f-75da-47a4-a5f2-d1f2b8a3e9c0", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "9904d6f8-afea-449e-be7f-4713b00b04bb", 26, 1, "Физкултурен салон" },
                    { "9b9a788c-2312-4247-b20c-99e20131eb06", 26, 1, "Работилница" },
                    { "a19c66a3-6d91-4f88-ad73-ae7414bfb1b9", 26, 1, "Градина за биоземеделие" },
                    { "a26478d7-6d75-463d-a69c-88220540fab6", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "b2020d8c-0f68-46ef-9626-b5f272666ceb", 26, 1, "Физика и астрономия" },
                    { "f726fc7c-afc6-4476-9605-f0526ecb2878", 26, 1, "Пространство \"Малки изследователи\"" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0f482e43-9502-4121-929e-283cb181cd73");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "13b3f872-9c6a-43e7-9674-b959d32758b3");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "39642982-b7ab-4fbf-8f63-953c5929f8fe");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "3b6590eb-eafb-4f60-86ff-18105c033744");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "3e7ccb16-fa6f-4dca-bfd9-63103c9dc3ec");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "3f193828-eabc-4c3b-8263-6f88790d9a2f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "5495e880-8d38-4868-8028-82f298527c56");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "691095f3-5f56-4dec-8f75-fbe7b9ab7cae");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "73072807-6997-460f-85b2-b646293e2f1e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "78def21f-75da-47a4-a5f2-d1f2b8a3e9c0");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9904d6f8-afea-449e-be7f-4713b00b04bb");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9b9a788c-2312-4247-b20c-99e20131eb06");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a19c66a3-6d91-4f88-ad73-ae7414bfb1b9");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a26478d7-6d75-463d-a69c-88220540fab6");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b2020d8c-0f68-46ef-9626-b5f272666ceb");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f726fc7c-afc6-4476-9605-f0526ecb2878");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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
    }
}
