using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Photo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "f1e469bc-af38-4208-84e1-2545b55fd55f");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ArticleId",
                table: "Photos",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "06afef81-f082-4d14-865b-f58b608de410");

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
    }
}
