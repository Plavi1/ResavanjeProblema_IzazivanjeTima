﻿using Korisnik.Areas.Identity.Data;
using System.Collections.Generic;

namespace Korisnik.ViewModel
{
    public class PosaljiIzazovViewModel
    {
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }
     
        public string IdIzazvanog { get; set; }
        public string ErrorPoruka { get; set; }


    }
}