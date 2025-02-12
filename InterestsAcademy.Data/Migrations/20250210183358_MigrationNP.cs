using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "e6bb13af-fe1e-4276-b301-1bffe7f8c8fc");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "31ef1bef-9221-436a-b9d8-53c2710834da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "22316917-9917-416a-8192-456be1c2ccc4", "AQAAAAIAAYagAAAAEA+iXLslGmFUgzSwtKh/5wufU3T/wkyVR2g8L3hMtLzep7B2o0cyqNj2OPdua7XHTw==", new DateTime(2025, 2, 10, 18, 33, 55, 671, DateTimeKind.Utc).AddTicks(602), "089a62cc-c242-423c-8cf9-b3e2d1ef853c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f0ff3fc7-78aa-4044-b4a2-a20bded70149", "AQAAAAIAAYagAAAAEON2KQB+wLT00eY4uR+hzdjBXg7Dp9oAjrvJpFAmF5uknAjFNFLrvLY0BQrSpNKy9g==", new DateTime(2025, 2, 10, 18, 33, 55, 961, DateTimeKind.Utc).AddTicks(1417), "6288d093-bfcd-44a0-86e8-7105d28d9f7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e1b519f0-d060-4158-ba27-19150d73fa62", "AQAAAAIAAYagAAAAEFHAq+oX54MV9yz5Up10LHFvXLp8livN9b2xSvbsXi9pBPbMJkKwe+veCaqsB9jnYw==", new DateTime(2025, 2, 10, 18, 33, 55, 836, DateTimeKind.Utc).AddTicks(4693), "c2879d81-4f6e-4ef2-bfb7-9e1463e88c0d" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "db7fc2e1-fedb-4fa9-ada7-ed5d401f1a26", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "db7fc2e1-fedb-4fa9-ada7-ed5d401f1a26");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "8587d2e0-8370-4a02-9024-44ecd55e5960", "AQAAAAIAAYagAAAAEO7zeZXu5mg2feXYU7r6b+jdPE0bILTaUeFIkS6SzayEfnScX3j1z1bS2fgGuC6Esg==", new DateTime(2025, 2, 2, 21, 54, 26, 578, DateTimeKind.Utc).AddTicks(2402), "320006ff-ea09-4c4e-80d6-b3e25654aebb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1be6670a-430d-46d1-adea-b38eab197394", "AQAAAAIAAYagAAAAEJ3dC+RkqaXcM+D9fDiS0frYWMM/rIDB5zmbxlp/O1DAUhsNIF6IxEIVnzMpIyjB/Q==", new DateTime(2025, 2, 2, 21, 54, 26, 848, DateTimeKind.Utc).AddTicks(6031), "4773b814-5fe8-49f4-9222-896372363516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6b9c49ff-405d-4d65-a38a-53e734640be6", "AQAAAAIAAYagAAAAEEjyKCxzQNzSbDgD+BLE/a1jPYXeCFEVsfsmXoquYj+dDLEhma/PYlrlf+0zKrNLjw==", new DateTime(2025, 2, 2, 21, 54, 26, 716, DateTimeKind.Utc).AddTicks(7408), "9fe1719c-61dd-4e97-8077-741c5a62e6ed" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Duration", "IsActive", "IsApproved", "Name", "RoomId", "TeacherId" },
                values: new object[] { "e6bb13af-fe1e-4276-b301-1bffe7f8c8fc", "Този курс предоставя задълбочен поглед върху основните принципи на биологията – от клетъчната структура и генетиката до екосистемите и еволюцията. Ще изследваме живите организми, техните процеси и взаимодействия, както и най-новите открития в областта. Подходящ за ученици, студенти и любители на науката, които искат да разберат по-добре света около себе си. ", "2 месеца", true, true, "Биология", "64ae1f9e-bc59-4356-b74e-887f08425106", "2644afb5-f916-4b3f-b451-9ff86c881de3" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "31ef1bef-9221-436a-b9d8-53c2710834da", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
