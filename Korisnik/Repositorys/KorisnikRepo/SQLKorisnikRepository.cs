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
        private readonly UserManager<ApplicationKorisnik> userManager;


        public SQLKorisnikRepository(KorisnikDbContext context, UserManager<ApplicationKorisnik> userManager)

        {

            this.context = context;
            this.userManager = userManager;
        }


        public IEnumerable<ApplicationKorisnik> SviKorisnici()
        {

            return context.Users;
        }
    }
}