using Korisnik.Areas;
using Korisnik.Models;
using System.Collections.Generic;

namespace Korisnik.ViewModel
{
    public class SveTabele_ViewModel                     //PRIVREMEN ViewModel ZA home/svetabele 
    {
        public IEnumerable<Izazovi> Izazovi { get; set; }
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }
        public IEnumerable<Prihvaceni_Izazovi> PrihvaceniIzazovi { get; set; }
    }
}
