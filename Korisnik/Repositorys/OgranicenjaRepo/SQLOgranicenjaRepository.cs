using Korisnik.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.OgranicenjaRepo
{
    public class SQLOgranicenjaRepository : IOgranicenjaRepository
    {
        private readonly KorisnikDbContext context;

        public SQLOgranicenjaRepository(KorisnikDbContext context)
        {
            this.context = context;
        }

        public async Task<Ogranicenja> AddOgranicenje(Ogranicenja ogranici)
        {
                context.Ogranicenja.Add(ogranici);
                await context.SaveChangesAsync();
                return ogranici;
            
        }

        public async Task<Ogranicenja> Delete(int id)
        {
           
                Ogranicenja ogranicenja = context.Ogranicenja.Find(id);
                if (ogranicenja != null)
                {
                    context.Ogranicenja.Remove(ogranicenja);
                    await context.SaveChangesAsync();
                }
                return ogranicenja;

        }

        public async Task<Ogranicenja> NadjiOgranicenje(int id)
        {
            return await context.Ogranicenja.FindAsync(id);
        }

        public IEnumerable<Ogranicenja> SvaOgranicenja()
        {
            return context.Ogranicenja;
        }

     
    }
}
