using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                    { "06fecce5-0e5d-44a6-852c-f44a7fade4fa", 26, 1, "Конферентна зала" },
                    { "1648d352-7f30-4ca9-aabc-dc9427a3584c", 26, 1, "Пространство за Археология" },
                    { "4ff194b9-d7ad-48c3-b3d0-e28f3c84cb43", 26, 1, "Работилница" },
                    { "71e581fe-eab1-481e-a3d3-94c8b92cf716", 26, 1, "Музикално студио" },
                    { "7448ec5d-3193-4e19-b033-cf4b18f7b446", 26, 1, "Физика и астрономия" },
                    { "822b0820-9d43-45b0-989e-32cecdf5b6f5", 26, 1, "Мултифункционална зала" },
                    { "882f851f-070d-4265-8a17-5590ee67a2ca", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "9f80befd-c5b9-4235-b84a-342a6a6ec8c5", 26, 1, "Еко стая" },
                    { "a015c56b-dc50-4110-91ad-2a798138423c", 26, 1, "Лаборатория" },
                    { "b0cd22a7-fb3b-488c-9b3b-4073ed717274", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "b230ce5b-03d6-4774-b0ae-a060c0336b68", 26, 1, "Физкултурен салон" },
                    { "beaf71a0-63e2-4166-87ed-7ad5b105845b", 26, 1, "Градина за биоземеделие" },
                    { "c00ad3ea-83a9-470c-925a-69f7fd6b074e", 26, 1, "Пространство \"Малки изследователи\"" },
                    { "d9a139e0-704d-4936-a7d3-322915601088", 26, 1, "Библиотека" },
                    { "e83a5a56-a9e3-436b-8041-fb593a04d02d", 26, 1, "Пространство за спорт на открито" },
                    { "f6402394-e974-4143-ad16-d9e2557a5926", 26, 1, "Пространство \"Роботика и програмиране\"" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "06fecce5-0e5d-44a6-852c-f44a7fade4fa");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1648d352-7f30-4ca9-aabc-dc9427a3584c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "4ff194b9-d7ad-48c3-b3d0-e28f3c84cb43");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "71e581fe-eab1-481e-a3d3-94c8b92cf716");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7448ec5d-3193-4e19-b033-cf4b18f7b446");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "822b0820-9d43-45b0-989e-32cecdf5b6f5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "882f851f-070d-4265-8a17-5590ee67a2ca");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "9f80befd-c5b9-4235-b84a-342a6a6ec8c5");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a015c56b-dc50-4110-91ad-2a798138423c");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b0cd22a7-fb3b-488c-9b3b-4073ed717274");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "b230ce5b-03d6-4774-b0ae-a060c0336b68");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "beaf71a0-63e2-4166-87ed-7ad5b105845b");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "c00ad3ea-83a9-470c-925a-69f7fd6b074e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d9a139e0-704d-4936-a7d3-322915601088");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "e83a5a56-a9e3-436b-8041-fb593a04d02d");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "f6402394-e974-4143-ad16-d9e2557a5926");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "AspNetUsers");

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
    }
}
