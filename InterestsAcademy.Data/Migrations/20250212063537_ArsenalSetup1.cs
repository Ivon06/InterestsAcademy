using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class ArsenalSetup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "340610ff-cc68-41a7-9a3e-3908d45d10d4", "AQAAAAIAAYagAAAAEEHkHTBStL+4aGYzRor2C6bLIbzbFbG/dvML9sDDf0Hzlph7ikNALvIuSZFoEcP7kg==", new DateTime(2025, 2, 12, 6, 35, 36, 511, DateTimeKind.Utc).AddTicks(1921), "69d04d89-ed3c-41e0-8103-05cd8ed60f39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "0f4a91a2-0a84-4aae-aca0-f6e18a2a8da1", "AQAAAAIAAYagAAAAEB4hl5RR5CMxPkeToLwdBxg6TmkezoACPFGMSVNhUsHX4FDZVrnyStMO6HS7DhR5fw==", new DateTime(2025, 2, 12, 6, 35, 36, 598, DateTimeKind.Utc).AddTicks(7932), "fc5f79cb-c80b-4dcc-8007-e314bd6e6375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b4c326b3-215f-441d-a5aa-b6c13ebccc9d", "AQAAAAIAAYagAAAAELoYwfdpqU7cE0Xq7u0kQQQjtbIAeyZqh+wntN6yInZTknsmShTAs8iZEw1XhMtnYQ==", new DateTime(2025, 2, 12, 6, 35, 36, 557, DateTimeKind.Utc).AddTicks(6280), "9d1b9660-4dbc-4eaa-9df6-82b8968a56b5" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "c7325480-d20e-4238-93eb-9aed667c2f83", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "c7325480-d20e-4238-93eb-9aed667c2f83");

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
    }
}
