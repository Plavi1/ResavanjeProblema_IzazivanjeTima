using Korisnik.Areas;
using Korisnik.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Korisnik.IdentityHostingStartup))]
namespace Korisnik
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<KorisnikDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("KorisnikDbContextConnection")));

                services.AddDefaultIdentity<ApplicationKorisnik>(options => {
                    options.SignIn.RequireConfirmedAccount = false;      // Ne mora da se potvrdi account, to jest ne mora da ulazi na email da bi potvrdio
                    options.Password.RequireLowercase = false;           // Ubacili smo da ne treba mala 
                    options.Password.RequireUppercase = false;           //    ,velika slova
                    options.Password.RequireNonAlphanumeric = false;     //      i !@#

                })
                    .AddRoles<IdentityRole>()                           // Dodato da bi omogucili manipulaciju sa role tabelama
                    .AddEntityFrameworkStores<KorisnikDbContext>();
                    


            });
        }
    }
}