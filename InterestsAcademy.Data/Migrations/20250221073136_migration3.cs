using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "554e73eb-e465-461b-b632-d76884ab79e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "51f03131-f37d-4225-b823-1c02a64b4af4", "AQAAAAIAAYagAAAAEDSIMGS7oJCH9ojTnR3PfcL+WsD2XekTkxxw8WwnxkobPgxJrOHfJWqfPal9+BjaHA==", new DateTime(2025, 2, 21, 7, 31, 35, 351, DateTimeKind.Utc).AddTicks(3039), "33cda995-d022-4aef-90b2-4ed392658edf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a882eee7-19bd-48c6-b1c4-60b7f365ab35", "AQAAAAIAAYagAAAAEAhX7ynHeFTkjbNUypgPm4LR7yU+byzGU33tfNmdyxXDLMwlAjGzjwQe+ygsreDD2g==", new DateTime(2025, 2, 21, 7, 31, 35, 437, DateTimeKind.Utc).AddTicks(1921), "cd4c2eeb-c74c-4354-99ea-b9c5a21a9b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "67c477b5-9258-4d56-a54d-62e0dcbd8226", "AQAAAAIAAYagAAAAEA32XRrA3g51OWPp2Os9MOaclU5oimivcUH/vwEoug0ADrODZupNAdwhVYkLRPRZMA==", new DateTime(2025, 2, 21, 7, 31, 35, 394, DateTimeKind.Utc).AddTicks(5521), "b570e318-72b0-452a-8b1b-c9cdcbf37755" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "5485efa5-f379-4a9a-8a5c-af32a5336fb6", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5485efa5-f379-4a9a-8a5c-af32a5336fb6");

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
