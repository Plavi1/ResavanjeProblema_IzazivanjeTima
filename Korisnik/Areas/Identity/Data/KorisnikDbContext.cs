using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Korisnik.Data
{
    public class KorisnikDbContext : IdentityDbContext<ApplicationKorisnik>
    {
        public KorisnikDbContext(DbContextOptions<KorisnikDbContext> options)
            : base(options)
        {
        }

        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; internal set; }
        public DbSet<Izazovi> Izazovi { get; set; }
        public DbSet<Prihvaceni_Izazovi> Prihvaceni_Izazovi { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            
        }
    }
}
