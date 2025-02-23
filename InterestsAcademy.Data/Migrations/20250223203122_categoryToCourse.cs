using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class categoryToCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "06afef81-f082-4d14-865b-f58b608de410");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "91ebec85-6486-40b7-853a-8dcf10451865", "AQAAAAIAAYagAAAAEK7TnWZeqGiLcYNp5DtXRlbTQVXC/hlMOke2EJSz/lRoBJGzm59OjKeUFME5GXqfbg==", new DateTime(2025, 2, 23, 20, 31, 21, 419, DateTimeKind.Utc).AddTicks(7570), "51ded319-5484-45dc-acd7-9438e6105264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "98e659b3-3306-43d8-970d-a61222c20386", "AQAAAAIAAYagAAAAEHQsH+3/T0YxEcFVdHR+BQqhm11BbEHmasfTcAkyO6wBDbZnkLONejVMKaRx6Z3Q0g==", new DateTime(2025, 2, 23, 20, 31, 21, 564, DateTimeKind.Utc).AddTicks(3298), "bd5c0912-1fc8-476c-b6a9-c2c4a0f027eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "c22f2611-0900-4364-b184-afc6023478b5", "AQAAAAIAAYagAAAAEHUrlUEfSfGxOdE7K6m4nlElvtd0Tw8tW2k2N89SZAuDGGBf7oc9dsh91cj5cnSfNg==", new DateTime(2025, 2, 23, 20, 31, 21, 497, DateTimeKind.Utc).AddTicks(753), "cfaebe3a-c933-48bf-8352-775dcca061f4" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "e6bb13af-fe1e-4276-b301-1bffe7f8c8fc",
                column: "Category",
                value: "Biology");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "a7f16ac5-331d-40f5-bccb-bb08775acd09", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a7f16ac5-331d-40f5-bccb-bb08775acd09");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "455a98a2-d92c-4a14-8f84-be153df7111e", "AQAAAAIAAYagAAAAEGYoSZw+vZ+qe6TpGQJyHzYxFmndl3wdTyrwWprLIHL/DMzMkSX3K5VaCCvy2f6xyQ==", new DateTime(2025, 2, 23, 17, 26, 25, 364, DateTimeKind.Utc).AddTicks(3073), "b0797c0f-27e0-4306-a7f3-2d6755487ab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ce5af7e3-09b9-4f03-a1ec-5aa18ff5d518", "AQAAAAIAAYagAAAAEMfhRbjDGWM0jEr3cVlQAn6CHGmnNTJtzase/7X/j2RzO8Sv6EQSbMtwtwvSxqg8mg==", new DateTime(2025, 2, 23, 17, 26, 25, 486, DateTimeKind.Utc).AddTicks(872), "1e86249f-f053-47f5-b62d-6511ac717216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "8ce1e547-b459-406d-9f3d-0a5389c8c3d0", "AQAAAAIAAYagAAAAEJTV/LZTiiDthD6u1g6xRlnt6SRZVa//LdPyuiSju2s9TFjNDEKIceMpgHsZKBMg0A==", new DateTime(2025, 2, 23, 17, 26, 25, 427, DateTimeKind.Utc).AddTicks(3450), "0d3c10e4-b8fd-4780-aa69-0b0c321ba394" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "06afef81-f082-4d14-865b-f58b608de410", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
