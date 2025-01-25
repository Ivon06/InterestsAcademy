using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestsAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialBaseItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeededQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialBaseItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SleepingRooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountOfBed = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepingRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Givers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiverType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Givers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Givers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SleepingRoomId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_SleepingRooms_SleepingRoomId",
                        column: x => x.SleepingRoomId,
                        principalTable: "SleepingRooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GivenThings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaterialItemId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GivenThings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GivenThings_Givers_GiverId",
                        column: x => x.GiverId,
                        principalTable: "Givers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GivenThings_MaterialBaseItems_MaterialItemId",
                        column: x => x.MaterialItemId,
                        principalTable: "MaterialBaseItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityStudents",
                columns: table => new
                {
                    ActivityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityStudents", x => new { x.StudentId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ActivityStudents_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78374b9b-5158-4aff-8626-d088a02d79e1", null, "Teacher", "TEACHER" },
                    { "78wijd768-7255-4iwf-9o23-6786yet54wa3", null, "Giver", "GIVER" },
                    { "835c8458-e8b7-493f-9c13-67bfcd7316a3", null, "Admin", "ADMIN" },
                    { "8duisjak-e8o7-8uu5-9c13-543e65731jh3", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "Gender", "IsActive", "IsApproved", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "RegisteredOn", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "080a469a-b5a2-44cc-a660-eea8e6fd05a5", 0, "ул. Ал. Стамболийски 30 ет.3 ап.11", new DateTime(2008, 4, 12, 13, 24, 0, 0, DateTimeKind.Unspecified), "Казанлък", "ea7206e1-eb5e-4cce-ba14-decea6ca04fb", "България", "petarpetrov@abv.bg", false, "Мъж", true, true, false, null, "Петър Петров", "PETARPETROV@ABV.BG", "PETAR", "AQAAAAIAAYagAAAAEGofDfwzoKcsWrrNWY3U4AmvevH6/fpTG9mQp5aMSef59J8IIMKWTlwzhc/Bipwy7w==", "0885763826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697607303/projectImages/xbhwflepot9qpwmiiq6u.jpg", new DateTime(2025, 1, 24, 6, 35, 29, 843, DateTimeKind.Utc).AddTicks(6481), "992ff756-b08e-4520-bf5e-a9cc9fa50700", false, "petar" },
                    { "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8", 0, "ул. Незабравка 3", new DateTime(2015, 7, 18, 11, 20, 0, 0, DateTimeKind.Unspecified), "Енина", "1966f05b-ef7a-40ef-970a-854c2566272b", "България", "admin@abv.bg", false, "Мъж", true, true, false, null, "Admin", "ADMIN@ABV.BG", "ADMIN", "AQAAAAIAAYagAAAAEL422fYHL67qUwwaTfxQ74qzvfMHJizCleYQLk/7KCwTPCzBnlcRA+Ur3NfImU7htw==", "0889864842", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697617373/projectImages/pyb6v86l6myou9h1sxca.jpg", new DateTime(2025, 1, 24, 6, 35, 30, 145, DateTimeKind.Utc).AddTicks(4565), "00db6ffb-607d-45e2-87e2-4af3e78da65f", false, "Admin" },
                    { "93418f37-da3b-4c78-b0ae-8f0022b09681", 0, "ул.Възраждане 6 ет.2 ап.8", new DateTime(1968, 2, 8, 11, 20, 0, 0, DateTimeKind.Unspecified), "Казанлък", "c7439f36-ca7b-4ba8-95c6-853890cef0cd", "България", "georgidimitrov@abv.bg", false, "Мъж", true, true, false, null, "Георги Димитров", "GEORGIDIMITROV@ABV.BG", "GEORGI", "AQAAAAIAAYagAAAAEBNl2YaNAYaAHQ+ySGebXx8P1EC8dbqCWAAVsuQowro+yLdOCJpIkW0jrBtmYz+5SQ==", "0885789826", false, "https://res.cloudinary.com/ddriqreo7/image/upload/v1697608565/projectImages/mvorrsshjbw1e8bzfzgq.jpg", new DateTime(2025, 1, 24, 6, 35, 30, 4, DateTimeKind.Utc).AddTicks(1664), "050c2da9-03cd-4ac6-a6af-dd3e3a611f52", false, "georgi" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "Name" },
                values: new object[,]
                {
                    { "05d0dcc0-fb13-4ef8-9948-a85cdad30177", 26, 1, "Лаборатория" },
                    { "1195d330-1959-432d-887f-27b8e92526f3", 26, 1, "Физика и астрономия" },
                    { "16adaa8f-5a29-4585-aecf-2588b43e7409", 26, 1, "Мултифункционална зала" },
                    { "17d1141d-72d8-4688-aa9a-6c6574ebb29b", 26, 1, "Дейности извън Академията - ориентиране в планината, конна езда, походи" },
                    { "1e233337-f3bb-4292-820e-bc3ce190f21e", 26, 1, "Градина за биоземеделие" },
                    { "268f61c2-4ca0-4008-891e-e5b753cb6824", 26, 1, "Еко стая" },
                    { "46121cab-ee82-410f-a8b6-bddc31bd4337", 26, 1, "Физкултурен салон" },
                    { "475146db-524c-4f99-843a-ca89ac806e25", 26, 1, "Работилница" },
                    { "811b5ff8-1c09-41a9-99aa-9ffa5e55b471", 26, 1, "Младежки клуб по видеозаснемане" },
                    { "955e715f-6d39-4933-b873-7fb148880ea5", 26, 1, "Музикално студио" },
                    { "a3131d13-bda7-4e04-9376-f1002f671db8", 26, 1, "Библиотека" },
                    { "b5c85d9f-2b47-4cb7-b6e1-3df1e80ddd94", 26, 1, "Конферентна зала" },
                    { "c6f60519-3c0d-488d-a958-a7c11eb85c4f", 26, 1, "Пространство \"Роботика и програмиране\"" },
                    { "cf38593c-8f51-43a8-95d2-44ea38c5f0a7", 26, 1, "Пространство за спорт на открито" },
                    { "dfb61eac-1b43-4697-89e4-f8ffc75b80ac", 26, 1, "Пространство за Археология" },
                    { "ee9a790a-f366-47ca-870e-a1b688bde068", 26, 1, "Пространство \"Малки изследователи\"" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8duisjak-e8o7-8uu5-9c13-543e65731jh3", "080a469a-b5a2-44cc-a660-eea8e6fd05a5" },
                    { "835c8458-e8b7-493f-9c13-67bfcd7316a3", "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8" },
                    { "78374b9b-5158-4aff-8626-d088a02d79e1", "93418f37-da3b-4c78-b0ae-8f0022b09681" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "SleepingRoomId", "UserId" },
                values: new object[] { "0b588f00-9c39-4cbd-8f94-fcc5c1bf7a60", null, "080a469a-b5a2-44cc-a660-eea8e6fd05a5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "2f7b3ba6-ebad-49e3-86ea-052b132439f5", "93418f37-da3b-4c78-b0ae-8f0022b09681" });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CourseId",
                table: "Activities",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityStudents_ActivityId",
                table: "ActivityStudents",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_RoomId",
                table: "Courses",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_GivenThings_GiverId",
                table: "GivenThings",
                column: "GiverId");

            migrationBuilder.CreateIndex(
                name: "IX_GivenThings_MaterialItemId",
                table: "GivenThings",
                column: "MaterialItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Givers_UserId",
                table: "Givers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CourseId",
                table: "Requests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TeacherId",
                table: "Requests",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SleepingRoomId",
                table: "Students",
                column: "SleepingRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityStudents");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GivenThings");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Givers");

            migrationBuilder.DropTable(
                name: "MaterialBaseItems");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "SleepingRooms");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
