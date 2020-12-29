using Korisnik.Data;
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

        public Izazovi AddIzazovi(Izazovi izazovi)
        {
          
            context.Izazovi.Add(izazovi);
            context.SaveChanges();
            return izazovi;
        }

        public Izazovi Delete(int id)
        {
            Izazovi izazov = context.Izazovi.Find(id);
            if (izazov != null)
            {
                context.Izazovi.Remove(izazov);
                context.SaveChanges();
            }
            return izazov;

        }

        public Izazovi GetIzazovi(int id)
        {
            return context.Izazovi.Find(id);
        }

        public IEnumerable<Izazovi> SviIzazovi()
        {
            return context.Izazovi;
        }

        public Izazovi UpdateIzazovi(Izazovi izazovPromena)
        {
            var izazov = context.Izazovi.Attach(izazovPromena);
            izazov.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return izazovPromena;

        }
    }
}