using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class UbacivanjeVremenaImesta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mesto",
                table: "Prihvaceni_Izazovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VremePoslatogIzazova",
                table: "Prihvaceni_Izazovi",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZakazanDatum",
                table: "Prihvaceni_Izazovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZakazanoVreme",
                table: "Prihvaceni_Izazovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mesto",
                table: "Izazovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VremePoslatogIzazova",
                table: "Izazovi",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZakazanDatum",
                table: "Izazovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZakazanoVreme",
                table: "Izazovi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mesto",
                table: "Prihvaceni_Izazovi");

            migrationBuilder.DropColumn(
                name: "VremePoslatogIzazova",
                table: "Prihvaceni_Izazovi");

            migrationBuilder.DropColumn(
                name: "ZakazanDatum",
                table: "Prihvaceni_Izazovi");

            migrationBuilder.DropColumn(
                name: "ZakazanoVreme",
                table: "Prihvaceni_Izazovi");

            migrationBuilder.DropColumn(
                name: "Mesto",
                table: "Izazovi");

            migrationBuilder.DropColumn(
                name: "VremePoslatogIzazova",
                table: "Izazovi");

            migrationBuilder.DropColumn(
                name: "ZakazanDatum",
                table: "Izazovi");

            migrationBuilder.DropColumn(
                name: "ZakazanoVreme",
                table: "Izazovi");
        }
    }
}
