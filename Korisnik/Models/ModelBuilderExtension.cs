using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Korisnik.Models
{
    public static class ModelBuilderExtension
    { 
        public static void SeedSuperAdmin(this ModelBuilder modelBuilder)
        {
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";   

            
            // Pravimo Admin Role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // Pravimo Korisnika
            var Korisnik = new Korisnici
            {
                Id = ADMIN_ID,
                Email = "Admin@admin.com",
                EmailConfirmed = true,
                UserName = "Admin@admin.com",
                LockoutEnabled = true, 
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM"
            };

            //Setuj Korisniku PW
            PasswordHasher<Korisnici> ph = new PasswordHasher<Korisnici>();
            Korisnik.PasswordHash = ph.HashPassword(Korisnik, "Sifra1");

            //Ubaci Korisnika
            modelBuilder.Entity<Korisnici>().HasData(Korisnik);
            

            //Postavi Korisnika za Admina
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }



        public static void SeedKorisnici(this ModelBuilder modelBuilder)
        {
            string KORISNIK1_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf1";
            string KORISNIK2_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf2";
            string KORISNIK3_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf3";
            string KORISNIK4_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf4";


            // Pravimo Korisnika
            var Korisnik1 = new Korisnici
            {
                Id = KORISNIK1_ID,
                Email = "korisnik1@korisnik1.com",
                Ime = "Korisnik1",
                Prezime = "Korisnik1",
                EmailConfirmed = true,
                UserName = "korisnik1@korisnik1.com",
                LockoutEnabled = true,
                NormalizedEmail = "KORISNIK1@KORISNIK1.COM",
                NormalizedUserName = "KORISNIK1@KORISNIK1.COM"
            };
            var Korisnik2 = new Korisnici
            {
                Id = KORISNIK2_ID,
                Email = "korisnik2@korisnik2.com",
                Ime = "Korisnik2",
                Prezime = "Korisnik2",
                EmailConfirmed = true,
                UserName = "korisnik2@korisnik2.com",
                LockoutEnabled = true,
                NormalizedEmail = "KORISNIK2@KORISNIK2.COM",
                NormalizedUserName = "KORISNIK2@KORISNIK2.COM"
            };
            var Korisnik3 = new Korisnici
            {
                Id = KORISNIK3_ID,
                Email = "korisnik3@korisnik3.com",
                Ime = "Korisnik3",
                Prezime = "Korisnik3",
                EmailConfirmed = true,
                UserName = "korisnik3@korisnik3.com",
                LockoutEnabled = true,
                NormalizedEmail = "KORISNIK3@KORISNIK3.COM",
                NormalizedUserName = "KORISNIK3@KORISNIK3.COM"
            };
            var Korisnik4 = new Korisnici
            {
                Id = KORISNIK4_ID,
                Email = "korisnik4@korisnik4.com",
                Ime = "Korisnik4",
                Prezime = "Korisnik4",
                EmailConfirmed = true,
                UserName = "korisnik4@korisnik4.com",
                LockoutEnabled = true,
                NormalizedEmail = "KORISNIK4@KORISNIK4.COM",
                NormalizedUserName = "KORISNIK4@KORISNIK4.COM"
            };


            //Setuj Korisniku PW
            PasswordHasher<Korisnici> ph = new PasswordHasher<Korisnici>();
            Korisnik1.PasswordHash = ph.HashPassword(Korisnik1, "Sifra1");
            Korisnik2.PasswordHash = ph.HashPassword(Korisnik2, "Sifra1");
            Korisnik3.PasswordHash = ph.HashPassword(Korisnik3, "Sifra1");
            Korisnik4.PasswordHash = ph.HashPassword(Korisnik4, "Sifra1");

            //Ubaci Korisnika
            modelBuilder.Entity<Korisnici>().HasData(Korisnik1,Korisnik2,Korisnik3,Korisnik4);

        }
    }
}
