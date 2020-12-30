using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.ViewModel
{
    public class ListaKorisnikaViewModel
    {
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }
     
        public string IdIzazvanog { get; set; }

        public string ErrorPoruka { get; set; }


    }
}