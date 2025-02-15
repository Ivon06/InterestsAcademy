using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class CayegoryForMaterialBaseItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "d3f68cc4-8b10-46d5-b310-47937d081fe5");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "MaterialBaseItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "432bfcde-1e4b-4ae4-8d1e-e1ca99fc944e", "AQAAAAIAAYagAAAAEBVDRFyBDHOOve6qDBNjD+tQUo31SxxBKHbaKrRBYbmBYKC9fvkY39khN2u21+qwgQ==", new DateTime(2025, 2, 15, 21, 15, 11, 603, DateTimeKind.Utc).AddTicks(5542), "10ea1b87-7127-49c1-a9db-11633e417964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a7c14f38-8547-4915-a97e-1e6587bda071", "AQAAAAIAAYagAAAAEEoVy3BYFXtdltTDG4mVQYTwCvNwAvNOklNdOUzs6kaxtMaWgD78tX67AFfd5Vsi2A==", new DateTime(2025, 2, 15, 21, 15, 11, 732, DateTimeKind.Utc).AddTicks(6896), "2afcb224-4704-4be0-96c2-ee558103e6aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "aa6a629a-a6b0-44c6-8e5f-d67c68bdc58c", "AQAAAAIAAYagAAAAEB7fRVcuJFrVYJqzcICFq9KkJHGUEpyOuFCxxJPnsiJZkOoyJoZ8qFbsAN2HpKM8Tw==", new DateTime(2025, 2, 15, 21, 15, 11, 671, DateTimeKind.Utc).AddTicks(1865), "8358d969-10c5-487e-8dcf-b64126ea8df7" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "0185d2f4-cd9c-4dd3-8afa-07a81f68653e", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0185d2f4-cd9c-4dd3-8afa-07a81f68653e");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "MaterialBaseItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d7a6a350-86fe-41f9-a89c-c18fd5f0ba4c", "AQAAAAIAAYagAAAAEA1FCsRcrDU8ns+9EwpG1jeEANIszV3VLmc001WhtvXKPuO3T+XY9zzL6NRM5NwSTA==", new DateTime(2025, 2, 14, 16, 7, 42, 48, DateTimeKind.Utc).AddTicks(987), "eea3b94b-08ff-42ec-9ace-6cd3ad02f6ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "aa4a8b78-b084-44b6-a1b1-caa618036ebd", "AQAAAAIAAYagAAAAEJg/13fvJovAoQ4rvcnSHecUCy+bzb1HsuiHNHfSw8pJ1eiPKR9/V7UuomHdVUq0Tg==", new DateTime(2025, 2, 14, 16, 7, 42, 333, DateTimeKind.Utc).AddTicks(3622), "f39d393e-3935-45a1-bbef-36af8ab9f64f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3244977e-044c-41d8-b5a1-df294af5dd13", "AQAAAAIAAYagAAAAEDLJtk1AmHU1cNL0UPwQR7gjrfKn2t9NdbeHKxbAP5az+FfcF/tWTdedQd8PotC+dw==", new DateTime(2025, 2, 14, 16, 7, 42, 198, DateTimeKind.Utc).AddTicks(2750), "a80e27dd-9081-422e-bb00-7c5a3f538da8" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "d3f68cc4-8b10-46d5-b310-47937d081fe5", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
