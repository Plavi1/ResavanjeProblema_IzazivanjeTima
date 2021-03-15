using Korisnik.Filteri;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.OgranicenjaRepo;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Korisnik
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IKorisnikRepository, SQLKorisnikRepository>();                           //Dodali Dependency Injection
            services.AddScoped<IIzazoviRepository, SQLIzazoviRepository>();                             //
            services.AddScoped<IPrihvaceni_IzazoviRepository, SQLPrihvaceni_IzazoviRepository>();       //
            services.AddScoped<IFilter, Filter>();                                                      //
            services.AddScoped<IOgranicenjaRepository, SQLOgranicenjaRepository>();                     //     

            services.AddAuthentication()
               .AddGoogle(options => {
                   options.ClientId = "365588186718-172m5c6md3c0goe9k58oljc0ichbd378.apps.googleusercontent.com";
                   options.ClientSecret = "yJaNwKgcFZZxlSbKFNHU6mZw";
               });
            services.AddRazorPages();                                                                   //Dodali
            services.AddControllersWithViews();
        }
         
      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {         
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();                                                       // Dodali

            app.UseAuthorization();           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();                                                 // Dodali 
            });
        }
    }
}
