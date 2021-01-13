using Korisnik.Areas.Identity.Data;
using Korisnik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.Prihvaceni_IzazoviRepo
{
    public class SQLPrihvaceni_IzazoviRepository : IPrihvaceni_IzazoviRepository
    {
        private readonly KorisnikDbContext context;

        public SQLPrihvaceni_IzazoviRepository(KorisnikDbContext context)
        {
            this.context = context;
        }

        public async Task<Prihvaceni_Izazovi> AddIzazovi(Prihvaceni_Izazovi izazovi)
        {
            context.Prihvaceni_Izazovi.Add(izazovi);
            await context.SaveChangesAsync();
            return izazovi;
        }

        public async Task<Prihvaceni_Izazovi> Delete(int id)
        {
            Prihvaceni_Izazovi izazov = context.Prihvaceni_Izazovi.Find(id);
            if (izazov != null)
            {
                context.Prihvaceni_Izazovi.Remove(izazov);
                await context.SaveChangesAsync();
            }
            return izazov;

        }

        public async Task<Prihvaceni_Izazovi> GetIzazovi(int id)
        {
            return await context.Prihvaceni_Izazovi.FindAsync(id);
        }

        public IEnumerable<Prihvaceni_Izazovi> SviIzazovi()
        {
            return context.Prihvaceni_Izazovi;
        }

        public async Task<Prihvaceni_Izazovi> UpdateIzazovi(Prihvaceni_Izazovi izazovPromena)
        {
            var izazov = context.Prihvaceni_Izazovi.Attach(izazovPromena);
            izazov.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
            return izazovPromena;

        }
    }
}
