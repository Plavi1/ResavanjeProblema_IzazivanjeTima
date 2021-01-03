using Korisnik.Areas.Identity.Data;
using Korisnik.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ApplicationKorisnik GetKorisnik (string id)
        {
          
            return context.Users.Find(id);
        }

        public IEnumerable<ApplicationKorisnik> SviKorisnici()
        {

            return context.Users;
        }
    }
}