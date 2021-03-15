using Korisnik.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Korisnik.Models
{
    public interface IKorisnikRepository
    {
        IEnumerable<ApplicationKorisnik> SviKorisnici();
        Task<ApplicationKorisnik> GetKorisnik (string id);






    }
}