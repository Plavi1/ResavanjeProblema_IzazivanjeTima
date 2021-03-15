using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.IzazoviRepo
{
    public class SQLIzazoviRepository : IIzazoviRepository
    {
        private readonly KorisnikDbContext context;

        public SQLIzazoviRepository(KorisnikDbContext context)
        {
            this.context = context;
        }

        public async Task<Izazovi> AddIzazovi(Izazovi izazovi)
        {
            context.Izazovi.Add(izazovi);
            await context.SaveChangesAsync();
            return izazovi;
        }

        public async Task<Izazovi> Delete(int id)
        {
            Izazovi izazov = context.Izazovi.Find(id);
            if (izazov != null)
            {
                context.Izazovi.Remove(izazov);
                await context.SaveChangesAsync();
            }
            return izazov;

        }

        public async Task<Izazovi> GetIzazovi(int id)
        {
            return await context.Izazovi.FindAsync(id);
        }

        public IEnumerable<Izazovi> SviIzazovi()
        {
            return context.Izazovi;
        }

        public async Task<Izazovi> UpdateIzazovi(Izazovi izazovPromena)
        {
            var izazov = context.Izazovi.Attach(izazovPromena);
            izazov.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
            return izazovPromena;

        }
    }
}