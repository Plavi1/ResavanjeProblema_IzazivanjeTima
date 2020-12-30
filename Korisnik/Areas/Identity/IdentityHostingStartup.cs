using System;
using Korisnik.Areas.Identity.Data;
using Korisnik.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Korisnik.Areas.Identity.IdentityHostingStartup))]
namespace Korisnik.Areas.Identity
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
                    options.Password.RequireLowercase = false;           //Ubacili smo da ne treba mala i velika slova i !@#
                    options.Password.RequireUppercase = false;           //
                    options.Password.RequireNonAlphanumeric = false;     // 

                })
                
                    .AddEntityFrameworkStores<KorisnikDbContext>();
                    
            });
        }
    }
}