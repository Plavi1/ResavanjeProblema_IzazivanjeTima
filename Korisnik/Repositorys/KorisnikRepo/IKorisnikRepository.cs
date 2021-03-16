using Korisnik.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Korisnik.Models
{
    public interface IKorisnikRepository
    {
        IEnumerable<Korisnici> SviKorisnici();
        Task<Korisnici> GetKorisnik (string id);






    }
}