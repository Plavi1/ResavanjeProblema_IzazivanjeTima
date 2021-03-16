using Microsoft.EntityFrameworkCore.Migrations;

namespace Korisnik.Migrations
{
    public partial class _4Korisnika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebe82e4b-c32a-45f0-957d-99c92d0a203e", "AQAAAAEAACcQAAAAEDwEnCTgHwyB0xfvKcsLt+2B4MfFaZIzd8axk3ohrBni3Av+WtTrlKXuHAU6ZOAySA==", "a1d667ca-c6c5-4d71-8b79-c547374ab59e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Ime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02174cf0–9412–4cfe-afbf-59f706d72cf1", 0, "d0c763c9-7c8c-416f-8d40-1762d7b81f43", "korisnik1@korisnik1.com", true, "Korisnik1", true, null, "KORISNIK1@KORISNIK1.COM", "KORISNIK1@KORISNIK1.COM", "AQAAAAEAACcQAAAAEGI+fUjW41tuu3rXmUiCKt7kv9HOzXh8+vm7qYMtRcqiF8km1VoLDRHtNqkL2meoeg==", null, false, "Korisnik1", "ee5aa074-4328-42a3-b5ee-36503a3bea88", false, "korisnik1@korisnik1.com" },
                    { "02174cf0–9412–4cfe-afbf-59f706d72cf2", 0, "9b79483e-6426-42b1-9be3-3e9cf3622a3c", "korisnik2@korisnik2.com", true, "Korisnik2", true, null, "KORISNIK2@KORISNIK2.COM", "KORISNIK2@KORISNIK2.COM", "AQAAAAEAACcQAAAAECy8KoEPGY3eNNu/ykPnfdO+sOTnIHXNCF+m3Pz/Ys62v+0GBZiJX8G+I1xluoFrCg==", null, false, "Korisnik2", "30069b08-d5d2-44dc-ba0a-24c62ddcda6c", false, "korisnik2@korisnik2.com" },
                    { "02174cf0–9412–4cfe-afbf-59f706d72cf3", 0, "d5c8eba6-1c43-41af-9b01-df708d74def9", "korisnik3@korisnik3.com", true, "Korisnik3", true, null, "KORISNIK3@KORISNIK3.COM", "KORISNIK3@KORISNIK3.COM", "AQAAAAEAACcQAAAAEEyijIhgFTONQsDYGsgq9qSWC/oLCW7nBRFZzk4Iu2d52iGU3tmgdLxiRbvMzrnttg==", null, false, "Korisnik3", "407c46fc-4d59-4e24-9552-6b6be3533774", false, "korisnik3@korisnik3.com" },
                    { "02174cf0–9412–4cfe-afbf-59f706d72cf4", 0, "db90ce67-c955-48e3-8f94-f235a94551ad", "korisnik4@korisnik4.com", true, "Korisnik4", true, null, "KORISNIK4@KORISNIK4.COM", "KORISNIK4@KORISNIK4.COM", "AQAAAAEAACcQAAAAEIgaOWuT1pr+3olwNTkkm5BH8XVbI9NUlNogLTix0BV+dATiR9UR2SWv/0EFY8OZSw==", null, false, "Korisnik4", "5cbe812f-8223-4d52-9239-338209fa3936", false, "korisnik4@korisnik4.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ec87029-a6af-49e1-8c8b-52adeae7e20d", "AQAAAAEAACcQAAAAEMqBHJaHOfI3MWjkInh6gyZ2j7+UU0A+DsAN6EB0UoFgsFP84CDStPWIjvqRskcSlA==", "13a2257a-4fa1-4c7d-8d28-abaf90f67655" });
        }
    }
}
