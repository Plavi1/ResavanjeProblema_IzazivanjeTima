using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class Prihvaceni_Izazovi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prihvaceni_Izazovi",
                columns: table => new
                {
                    IdIzazova = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIzazivaoca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdIzazavanog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImeIzazivaoca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImeIzazvanog = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prihvaceni_Izazovi", x => x.IdIzazova);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prihvaceni_Izazovi");
        }
    }
}
