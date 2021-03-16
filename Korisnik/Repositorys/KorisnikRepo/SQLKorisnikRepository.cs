using Korisnik.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Korisnik.Models
{
    public class SQLKorisnikRepository : IKorisnikRepository
    {
        private readonly KorisnikDbContext context;
        


        public SQLKorisnikRepository(KorisnikDbContext context)

        {

            this.context = context;
            
        }

        public async Task<Korisnici> GetKorisnik (string id)
        {
          
            return await context.Users.FindAsync(id);
        }

        public IEnumerable<Korisnici> SviKorisnici()
        {

            return context.Users;
        }
    }
}