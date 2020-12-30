using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class DodavanjeIzazova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izazovi",
                columns: table => new
                {
                    IdIzazova = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIzazivaoca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdIzazavanog = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izazovi", x => x.IdIzazova);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izazovi");
        }
    }
}
