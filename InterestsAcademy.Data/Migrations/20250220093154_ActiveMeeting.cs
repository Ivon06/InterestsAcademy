using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActiveMeeting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "554e73eb-e465-461b-b632-d76884ab79e6");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "73d849b9-c6f8-4582-96c6-ba3adccbeb76");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Activities");

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
    }
}
