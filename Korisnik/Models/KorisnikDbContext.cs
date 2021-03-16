using System;
using System.Collections.Generic;
using System.Linq;
using Korisnik.Models;
using Korisnik.ViewModel.Enum;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Korisnik.Models
{
    public class KorisnikDbContext : IdentityDbContext<Korisnici>
    {
        public KorisnikDbContext(DbContextOptions<KorisnikDbContext> options)
            : base(options)
        {
        }
        public IEnumerable<Korisnici> ApplicationKorisnik { get; internal set; }
        public DbSet<Izazovi> Izazovi { get; set; }
        public DbSet<Prihvaceni_Izazovi> Prihvaceni_Izazovi { get; set; }
        public DbSet<Ogranicenja> Ogranicenja { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedSuperAdmin();
            builder.SeedKorisnici();
            builder.Entity<Izazovi>()                                         //{     
                        .Property(e => e.Mesto)                               //{
                        .HasConversion(                                       //{ Konvertovanje Enuma u string
                        v => v.ToString(),                                    //{
                        v => (Mesta)Enum.Parse(typeof(Mesta), v)              //{
                      );
            builder.Entity<Prihvaceni_Izazovi>()                              //{     
                        .Property(e => e.Mesto)                               //{
                        .HasConversion(                                       //{ Konvertovanje Enuma u string
                        v => v.ToString(),                                    //{
                        v => (Mesta)Enum.Parse(typeof(Mesta), v)              //{
                      );
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))                 // Cascade od Delete za ForeignKeys
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
    }
}
