using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class MaterialBaseItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialBaseItemId",
                table: "GivenThings");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0409bdd7-3959-43e7-813f-253f785a8ecc");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialBaseItemId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialBaseItemId",
                table: "GivenThings",
                column: "MaterialBaseItemId",
                principalTable: "MaterialBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialBaseItemId",
                table: "GivenThings");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7ed83c69-65ef-4ca0-ad8e-6f82b330cac9");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialBaseItemId",
                table: "GivenThings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d304b958-f437-4104-bbb6-dcfb64238f60", "AQAAAAIAAYagAAAAEJ5h5c0qFqI/iNbpO9AZJP0RwSDSoiXwiGZ80nhhICBZBf2C3t70cXB4ueqM1sAr5g==", new DateTime(2025, 2, 19, 6, 35, 31, 868, DateTimeKind.Utc).AddTicks(1970), "1e92a4f7-b305-4737-bf0f-5f709a5b1d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "cbaa2f3c-4044-48cd-b9dd-6be71789da97", "AQAAAAIAAYagAAAAEI7+0lO3fxtxTrbAwdmhBxmOVzdheP6TtbdR7GchLgcPF6r/aWirpk01Nskszq6brw==", new DateTime(2025, 2, 19, 6, 35, 31, 956, DateTimeKind.Utc).AddTicks(2663), "e73550f7-0de4-4eb2-87ba-d2de24e547d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5dee902f-398a-4f99-a021-e5b8d801d1a8", "AQAAAAIAAYagAAAAEA0SBUUlNht1dfCm30MQn/oEFMPXC4k38sMhReBXujD1IzAm9XH7LJZyTeaJLbU9iA==", new DateTime(2025, 2, 19, 6, 35, 31, 913, DateTimeKind.Utc).AddTicks(2073), "24f96f66-f015-48ad-822f-02bf6f8a6d03" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "0409bdd7-3959-43e7-813f-253f785a8ecc", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.AddForeignKey(
                name: "FK_GivenThings_MaterialBaseItems_MaterialBaseItemId",
                table: "GivenThings",
                column: "MaterialBaseItemId",
                principalTable: "MaterialBaseItems",
                principalColumn: "Id");
        }
    }
}
