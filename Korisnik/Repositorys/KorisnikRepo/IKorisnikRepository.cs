using Korisnik.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Models
{
    public interface IKorisnikRepository
    {
        IEnumerable<ApplicationKorisnik> SviKorisnici();
        ApplicationKorisnik GetKorisnik (string id);






    }
}