using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsActiveToArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "366a659a-45d2-4fc6-811e-3b04ad4b8ea7");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3f45de11-916e-4d9f-9ff0-39fc66f1e10f", "AQAAAAIAAYagAAAAEKeuWNxAthwInuJd5VhixBEt++/lHZbY4qjLawjtwelLTEdAzzeKsKWH2W1Nib6/2w==", new DateTime(2025, 2, 17, 19, 27, 29, 436, DateTimeKind.Utc).AddTicks(9516), "a8e36b13-0b66-44b8-915c-c31358f6dff7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "920ed1d7-8d94-43af-a5f5-e29815816b60", "AQAAAAIAAYagAAAAEBFmwZEp3N52pJp3s6o/xzMeAbwzIKkrVp+IFwlteksRnOoC0ZLW1u/IVN57KFBZfA==", new DateTime(2025, 2, 17, 19, 27, 29, 696, DateTimeKind.Utc).AddTicks(6910), "fb4b5e2e-0eb3-478a-962c-0e4001707e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e43eaf58-2d70-4b55-a269-e5a90a4e6ec8", "AQAAAAIAAYagAAAAEDQNErluTAlwaAsSG4kNGQM+vV96XzU9v5QZ322c1qWGBbmDLG9AnY8RkwGMiTKRXQ==", new DateTime(2025, 2, 17, 19, 27, 29, 575, DateTimeKind.Utc).AddTicks(6051), "44984a6c-365a-4079-8e14-53739624ac7a" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "c3098d2e-85a9-4c7c-887f-7632425f25ed", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "c3098d2e-85a9-4c7c-887f-7632425f25ed");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ca8bc7a3-7ac8-401d-a7e2-7637449221d1", "AQAAAAIAAYagAAAAEGtXjBCgk3rXip5kPK62KONQ9jo+UbMwAELMbrz/bqS9UqqwrH+0l3E96k8EddpocA==", new DateTime(2025, 2, 14, 18, 23, 43, 492, DateTimeKind.Utc).AddTicks(9447), "d0d8cba4-fe2f-40cb-8184-e8dc506ddb7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "59bb424c-9f94-4b6e-ac06-e98dac2e22ac", "AQAAAAIAAYagAAAAEPXglqNDu5VI8Lv8rljHunnaWyitB15JHBXb/l780IL6DhVBWiYSoJL6XyU9NxKc4A==", new DateTime(2025, 2, 14, 18, 23, 43, 735, DateTimeKind.Utc).AddTicks(9512), "6a6cab15-fa6c-4a1c-8ad3-d26f329d9760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93418f37-da3b-4c78-b0ae-8f0022b09681",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5cce308a-d344-4043-94c7-32b4b6c34383", "AQAAAAIAAYagAAAAELWuG3v0Q88pvxsYYPf+8ujrZxMdd0n98OZy3eSRPIOFdb/diFuHThIsXwzzb1qh2Q==", new DateTime(2025, 2, 14, 18, 23, 43, 618, DateTimeKind.Utc).AddTicks(8093), "d7048da4-96f5-4967-baaf-df6ff21c7636" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "366a659a-45d2-4fc6-811e-3b04ad4b8ea7", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });
        }
    }
}
