using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class Ostalo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izazovi",
                columns: table => new
                {
                    IdIzazova = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIzazivaoca = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdIzazavanog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImeIzazivaoca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImeIzazvanog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VremePoslatogIzazova = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZakazanoVreme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZakazanDatum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izazovi", x => x.IdIzazova);
                    table.ForeignKey(
                        name: "FK_Izazovi_AspNetUsers_IdIzazivaoca",
                        column: x => x.IdIzazivaoca,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogranicenja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKorisnika = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdSaKojimOgranicavamKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogranicenja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogranicenja_AspNetUsers_IdKorisnika",
                        column: x => x.IdKorisnika,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prihvaceni_Izazovi",
                columns: table => new
                {
                    IdIzazova = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIzazivaoca = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdIzazavanog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImeIzazivaoca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImeIzazvanog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VremePoslatogIzazova = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZakazanoVreme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZakazanDatum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prihvaceni_Izazovi", x => x.IdIzazova);
                    table.ForeignKey(
                        name: "FK_Prihvaceni_Izazovi_AspNetUsers_IdIzazivaoca",
                        column: x => x.IdIzazivaoca,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Ime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02174cf0–9412–4cfe-afbf-59f706d72cf6", 0, "3ec87029-a6af-49e1-8c8b-52adeae7e20d", "Admin@admin.com", true, null, true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMqBHJaHOfI3MWjkInh6gyZ2j7+UU0A+DsAN6EB0UoFgsFP84CDStPWIjvqRskcSlA==", null, false, null, "13a2257a-4fa1-4c7d-8d28-abaf90f67655", false, "Admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "02174cf0–9412–4cfe-afbf-59f706d72cf6" });

            migrationBuilder.CreateIndex(
                name: "IX_Izazovi_IdIzazivaoca",
                table: "Izazovi",
                column: "IdIzazivaoca");

            migrationBuilder.CreateIndex(
                name: "IX_Ogranicenja_IdKorisnika",
                table: "Ogranicenja",
                column: "IdKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prihvaceni_Izazovi_IdIzazivaoca",
                table: "Prihvaceni_Izazovi",
                column: "IdIzazivaoca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izazovi");

            migrationBuilder.DropTable(
                name: "Ogranicenja");

            migrationBuilder.DropTable(
                name: "Prihvaceni_Izazovi");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "02174cf0–9412–4cfe-afbf-59f706d72cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341743f0-asd2–42de-afbf-59kmkkmk72cf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6");
        }
    }
}
