﻿using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.ViewModel
{
    public class SveTabele                     //PRIVREMEN ViewModel ZA home/svetabele 
    {
        public IEnumerable<Izazovi> Izazovi { get; set; }
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }
        public int id { get; set; }
    }
}