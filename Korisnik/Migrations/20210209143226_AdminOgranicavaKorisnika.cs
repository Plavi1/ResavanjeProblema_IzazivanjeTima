using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class AdminOgranicavaKorisnika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogranicenja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSaKojimOgranicavamKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogranicenja", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b2e05c3-049a-48d5-84d4-938713194775", "AQAAAAEAACcQAAAAEDE9VGGttb21PHa3wFyuxB7UP52fJwVDe+YNVjUujI7CqAgfT7C7OJysCv7EArSDqA==", "a26eb5a0-932e-44ce-a8cf-b866c2d264b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogranicenja");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d154ca-ea85-4389-be95-59b0b2431367", "AQAAAAEAACcQAAAAEAy21Z+I4IxTIFQbQ92VlkKRPzU61f1Zss4N0tdZXOlsKTeQLS2dI36Tz1rDjEsKmQ==", "f9dca33f-279c-4dac-8ea3-93c6bb4d4327" });
        }
    }
}
