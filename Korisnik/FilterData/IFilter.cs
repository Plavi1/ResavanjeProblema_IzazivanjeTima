using Korisnik.Areas.Identity.Data;
using System.Collections.Generic;

namespace Korisnik.Filteri
{
    public interface IFilter
    {
        IEnumerable<ApplicationKorisnik> PosaljiIzazovFilterTabele(string idUlogovanog);
    }
}
