using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class article : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "73d849b9-c6f8-4582-96c6-ba3adccbeb76");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6227689c-4a7b-4b14-87eb-fd8d565cd78f", "AQAAAAIAAYagAAAAEMqrn20P08CflVW/tqGCzjLcu+snQ+YmeTQCNQveafF2FcLBFUSEgDb790zkY8Hq0g==", new DateTime(2025, 2, 20, 9, 31, 52, 729, DateTimeKind.Utc).AddTicks(7393), "055fcd2b-61ac-4630-9a06-03c9b6fe5a1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "8ba3aaa6-1b6d-42ee-8422-345bced65cfb", "AQAAAAIAAYagAAAAEJo9c+HBi5UAaAiIv0obS/GXEpb7JA6XpNRD2Ft1Ffwwl9Eh1V01OIMhw4jNnn52sQ==", new DateTime(2025, 2, 20, 9, 31, 52, 862, DateTimeKind.Utc).AddTicks(6380), "814ffbd4-c2c6-49bd-a48c-c0162d9e588d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "99539ae5-d46b-4d44-8297-a79daa6e744a", "AQAAAAIAAYagAAAAECabDxAQvDOjese92ukxqMSWBIjeIJothuOtpuheYkRBX52a3umUSeCsd/gVqVpMXg==", new DateTime(2025, 2, 20, 9, 31, 52, 798, DateTimeKind.Utc).AddTicks(8864), "8a688ca2-ba3a-4c3a-ba86-83f1331ac17c" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "73d849b9-c6f8-4582-96c6-ba3adccbeb76", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
