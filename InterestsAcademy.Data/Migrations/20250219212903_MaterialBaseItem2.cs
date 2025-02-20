using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class MaterialBaseItem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7ed83c69-65ef-4ca0-ad8e-6f82b330cac9");

            migrationBuilder.AlterColumn<string>(
                name: "GiverId",
                table: "GivenThings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "GiverEmail",
                table: "GivenThings",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GiverName",
                table: "GivenThings",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7fba2988-7de0-479a-b250-8fb98b27d236", "AQAAAAIAAYagAAAAEBFwi6TjtyogrSfo/0nPzch3V7rZMa984VSFlnxXrdDFBX4SrWnXfIoeDZ5AL/gi7Q==", new DateTime(2025, 2, 19, 21, 29, 1, 153, DateTimeKind.Utc).AddTicks(1808), "456594bc-f69a-465d-bcf6-4ce6926691d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "dd61d7bc-eefc-4602-9645-168ddb59128b", "AQAAAAIAAYagAAAAEAQR6KarvJm3ZQiUX8nY0A2f0myd7aUob7pIdNn3tazKrfcfO97wKiSkpdwNtcMPiQ==", new DateTime(2025, 2, 19, 21, 29, 1, 469, DateTimeKind.Utc).AddTicks(7338), "606bbb7f-c86e-45ab-bdaf-936fe62ce5a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b2a1758a-09cb-4312-84d8-7394448c3252", "AQAAAAIAAYagAAAAEJ5j4gwRJ1FjsSleMFM0+27ximh9bPCofIMKu/FK+/+KI4S14yw916BKNPN2Q9/SFw==", new DateTime(2025, 2, 19, 21, 29, 1, 289, DateTimeKind.Utc).AddTicks(7003), "08b5f71d-babf-4b40-bc26-62c5e9a68f47" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "554e73eb-e465-461b-b632-d76884ab79e6", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "554e73eb-e465-461b-b632-d76884ab79e6");

            migrationBuilder.DropColumn(
                name: "GiverEmail",
                table: "GivenThings");

            migrationBuilder.DropColumn(
                name: "GiverName",
                table: "GivenThings");

            migrationBuilder.AlterColumn<string>(
                name: "GiverId",
                table: "GivenThings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2e1270b5-1562-4917-95f1-6f45bc71d120", "AQAAAAIAAYagAAAAEMrpZuJy2wwgzpjeohXAPkfMc3KwkanYUSTbLwooRKVwdWYunkLkQDNOJuxg5ott3A==", new DateTime(2025, 2, 19, 21, 0, 10, 194, DateTimeKind.Utc).AddTicks(7675), "9fe0ed48-f91d-46d3-b2fe-0441359a4805" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5c9eae1b-bafe-479c-ad8c-6e77b019eca9", "AQAAAAIAAYagAAAAEOmR4aFkAR4mXF8ufwmmkDotJFPnvfdzfFzPLnkRXO6bahZymNGvKPKP7IF4hMK+gw==", new DateTime(2025, 2, 19, 21, 0, 10, 492, DateTimeKind.Utc).AddTicks(8323), "a8c92cd4-54dc-4e91-bdee-e05f051b5465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3bdab891-6f58-4141-b6da-0600835e7fd7", "AQAAAAIAAYagAAAAELv3dbpuIJTGgAMYCSTNyj8ThVREYKN8w9wkqLKpdPIugNf+08DP5GcOrnrwftJYgg==", new DateTime(2025, 2, 19, 21, 0, 10, 352, DateTimeKind.Utc).AddTicks(5960), "50ea66a8-9acb-48e9-bc7f-ae5698672efd" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "7ed83c69-65ef-4ca0-ad8e-6f82b330cac9", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
