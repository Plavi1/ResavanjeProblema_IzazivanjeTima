using Korisnik.Areas.Identity.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Korisnik.ViewModel
{
    public class PosaljiIzazov_ViewModel
    {
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }

        public string IdIzazvanog { get; set; }
        public string ErrorPoruka { get; set; }


    }
}