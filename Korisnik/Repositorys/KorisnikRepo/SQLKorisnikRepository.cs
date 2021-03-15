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

        public async Task<ApplicationKorisnik> GetKorisnik (string id)
        {
          
            return await context.Users.FindAsync(id);
        }

        public IEnumerable<ApplicationKorisnik> SviKorisnici()
        {

            return context.Users;
        }
    }
}