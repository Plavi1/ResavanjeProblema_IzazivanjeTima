using Korisnik.Areas;
using Korisnik.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Areas
{
    public interface IKorisnikRepository
    {
        IEnumerable<ApplicationKorisnik> SviKorisnici();
        Task<ApplicationKorisnik> GetKorisnik (string id);






    }
}