using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbChangedAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "01e184ff-f8f5-4765-af22-06e9b0386f1a", 26, 1, "Библиотека" },
                    { "126c1e85-dfc1-4679-a855-a89a4f2835f0", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "26ff84de-1d5f-4f3d-ab83-e70d23a2ec0b", 26, 1, "Физика и астрономия" },
                    { "2cea15dc-3304-4053-890b-1080cf3f0383", 26, 1, "Лаборатория" },
                    { "2f4c49cf-f874-4a9b-9aa6-4fc4f3e1fecf", 26, 1, "Работилница" },
                    { "637500cd-bdbc-4f71-b5a3-be1e90441c5e", 26, 1, "Градина за биоземеделие" },
                    { "7209be37-f466-4bb6-a296-a94d4da963ca", 26, 1, "Физкултурен салон" },
                    { "792204ee-535f-4103-a754-24af3969e22f", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "a5102309-1b95-4148-80ae-5bfb0a9b97e5", 26, 1, "Еко стая" },
                    { "ada6fb51-2620-4e31-8dfe-5e14496eba1e", 26, 1, "Музикално студио" },
                    { "c69ff94b-8a54-4cf0-92b4-a4cdbeea8025", 26, 1, "Пространство за Археология" },
                    { "cfefdca3-e2ab-470e-b26d-a65957031db8", 26, 1, "Конферентна зала" },
                    { "e367f38c-2b2d-4f9e-9c7e-c61b8e7e621d", 26, 1, "Пространство за спорт на открито" },
                    { "e5447dea-c965-452a-acf3-345ebfbece6c", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "ea6f561c-86c3-452e-8767-e2a4a260cf3d", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "eef8f443-08f0-4e9d-bbbc-99d59b0a8be9", 26, 1, "Мултифункционална зала" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "01e184ff-f8f5-4765-af22-06e9b0386f1a");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "126c1e85-dfc1-4679-a855-a89a4f2835f0");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "26ff84de-1d5f-4f3d-ab83-e70d23a2ec0b");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2cea15dc-3304-4053-890b-1080cf3f0383");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "2f4c49cf-f874-4a9b-9aa6-4fc4f3e1fecf");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "637500cd-bdbc-4f71-b5a3-be1e90441c5e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7209be37-f466-4bb6-a296-a94d4da963ca");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "792204ee-535f-4103-a754-24af3969e22f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a5102309-1b95-4148-80ae-5bfb0a9b97e5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ada6fb51-2620-4e31-8dfe-5e14496eba1e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c69ff94b-8a54-4cf0-92b4-a4cdbeea8025");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "cfefdca3-e2ab-470e-b26d-a65957031db8");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e367f38c-2b2d-4f9e-9c7e-c61b8e7e621d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e5447dea-c965-452a-acf3-345ebfbece6c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ea6f561c-86c3-452e-8767-e2a4a260cf3d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "eef8f443-08f0-4e9d-bbbc-99d59b0a8be9");

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
        }
    }
}
