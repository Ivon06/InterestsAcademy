using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Photo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a40a122a-d788-4352-aaba-ac831a44d7ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ba0937ed-a497-4ed8-98c8-01bf2a9bd9cd", "AQAAAAIAAYagAAAAEMeTISPMQu9rxf4yJ31OBGGPT99y9ClNQsPN8DtjL4ntV5QA0fSIrWz1ESPXqKokFQ==", new DateTime(2025, 2, 23, 17, 24, 42, 388, DateTimeKind.Utc).AddTicks(273), "a276b455-31a9-4be0-9140-dd8dbcbc9087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "09b3dda4-b5f7-41f4-84fe-58e33bdb056e", "AQAAAAIAAYagAAAAEOV2jSvZOgI5uOfkwrkl+rJ/VlMm+I8413WTAeiSSGEY1yALtaGpeyyApNQ+MBrI0Q==", new DateTime(2025, 2, 23, 17, 24, 42, 509, DateTimeKind.Utc).AddTicks(436), "20d1ad28-4348-4082-b4de-1418d80e1f72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4095e6e5-4dd8-4bb6-a727-d3074a8ac937", "AQAAAAIAAYagAAAAEDrXyy+NE9pxRm4E9vpelWXSPFsiQmYhmpv+O5rKpwixeT8GcFlTl1WDOmdvfxK5/w==", new DateTime(2025, 2, 23, 17, 24, 42, 451, DateTimeKind.Utc).AddTicks(1538), "9e7d2c31-f5cc-4097-a91d-40fc978d36b6" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "f1e469bc-af38-4208-84e1-2545b55fd55f", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "f1e469bc-af38-4208-84e1-2545b55fd55f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f61dce62-c082-4b08-8dfe-1466beb61c19", "AQAAAAIAAYagAAAAEGi9Qf28TKZSTvY3ioTnSChwhDN4BbM8wxPD3c8k8hCkmmQ7HcO77KECBXweQtn0GA==", new DateTime(2025, 2, 22, 21, 44, 26, 3, DateTimeKind.Utc).AddTicks(1536), "fee8dc6a-0c3c-4d88-89eb-7d1f7716bf54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d05b8555-1086-452a-81cd-22c6458749eb", "AQAAAAIAAYagAAAAEDehLfLVDQXrz1tnEMzwe/QY8Bb1jXikx1HRBs8KfN5fHdm3FBUSVnad3W0YBp/tvg==", new DateTime(2025, 2, 22, 21, 44, 26, 299, DateTimeKind.Utc).AddTicks(6011), "38558fd1-e051-48c5-bd0b-2ea3d30f0c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "645c704e-4c52-43e3-a7d3-f3cd3e29fde9", "AQAAAAIAAYagAAAAEHh9URd2yidTfUoneR4mL8BGGiAHQ50gs57v10d2SMVHCmyy/xtSLpPchxVVLJ6P/w==", new DateTime(2025, 2, 22, 21, 44, 26, 173, DateTimeKind.Utc).AddTicks(1614), "cdde6508-a317-47c0-8a7f-2d41ffd7b09c" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "a40a122a-d788-4352-aaba-ac831a44d7ad", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
