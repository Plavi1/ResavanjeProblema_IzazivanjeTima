using Korisnik.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Korisnik.Models
{
    public static class ModelBuilderExtension
    { 
        public static void Seed(this ModelBuilder modelBuilder)
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
            var Korisnik = new ApplicationKorisnik
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
            PasswordHasher<ApplicationKorisnik> ph = new PasswordHasher<ApplicationKorisnik>();
            Korisnik.PasswordHash = ph.HashPassword(Korisnik, "Sifra1");

            //Ubaci Korisnika
            modelBuilder.Entity<ApplicationKorisnik>().HasData(Korisnik);
            

            //Postavi Korisnika za Admina
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
