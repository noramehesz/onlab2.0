using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrillBerWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grills",
                columns: table => new
                {
                    GrillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrillType = table.Column<string>(nullable: false),
                    GrillDecription = table.Column<string>(nullable: true),
                    GrillPricePerHour = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grills", x => x.GrillId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationDate = table.Column<DateTime>(nullable: false),
                    ReservatorName = table.Column<string>(nullable: false),
                    ReservationAddress = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<int>(nullable: false),
                    ReservationComment = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrillReservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(nullable: false),
                    GrillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrillReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrillReservation_Grills_GrillId",
                        column: x => x.GrillId,
                        principalTable: "Grills",
                        principalColumn: "GrillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrillReservation_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "2012f5d5-65f9-45f1-9617-7b17e1f94679", "janos@gmail.com", false, false, null, "janos@gmail.com", "janos@gmail.com", "AQAAAAEAACcQAAAAECtCenyxeSGpTeXzwgQeESc9BiYlXq1Aw4BDWttDopnD6g8gEGH76Xw1DFHgyjAILQ==", null, false, "", false, "janos@gmail.com" },
                    { "2", 0, "45f5c3b8-e4cf-4eb2-bd24-6f76e91b3676", "julia@hotmail.com", false, false, null, "julia@hotmail.com", "julia@hotmail.com", "AQAAAAEAACcQAAAAEMkXw6Gw2GxgocSkr5231rkCPL+YVUu7NoF0dRi1av5gAHTiFwBnhdvewyUTGbDRBg==", null, false, "", false, "julia@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Grills",
                columns: new[] { "GrillId", "GrillDecription", "GrillPricePerHour", "GrillType" },
                values: new object[,]
                {
                    { 1, "in new condition", 1500, "charcoal grill" },
                    { 2, "red coloured grill", 2500, "gas grill" },
                    { 3, "brandnew grill with free towel", 3000, "gas grill" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "PhoneNum", "ReservationAddress", "ReservationComment", "ReservationDate", "ReservatorName", "UserId" },
                values: new object[] { 1, 0, "Budapest 7. kerület Wesselényi utca 56.", null, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiss Janos", "1" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "PhoneNum", "ReservationAddress", "ReservationComment", "ReservationDate", "ReservatorName", "UserId" },
                values: new object[] { 2, 0, "Budapest Újpest központi parkoló", null, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiss Janos", "1" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "PhoneNum", "ReservationAddress", "ReservationComment", "ReservationDate", "ReservatorName", "UserId" },
                values: new object[] { 3, 0, "Bp 14. ker", null, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiss Janos", "1" });

            migrationBuilder.InsertData(
                table: "GrillReservation",
                columns: new[] { "Id", "GrillId", "ReservationId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "GrillReservation",
                columns: new[] { "Id", "GrillId", "ReservationId" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.InsertData(
                table: "GrillReservation",
                columns: new[] { "Id", "GrillId", "ReservationId" },
                values: new object[] { 3, 3, 3 });

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
                name: "IX_GrillReservation_GrillId",
                table: "GrillReservation",
                column: "GrillId");

            migrationBuilder.CreateIndex(
                name: "IX_GrillReservation_ReservationId",
                table: "GrillReservation",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "GrillReservation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Grills");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
