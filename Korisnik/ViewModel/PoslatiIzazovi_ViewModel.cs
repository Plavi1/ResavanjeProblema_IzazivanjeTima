using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.ViewModel
{
    public class PoslatiIzazovi_ViewModel
    {
        public IEnumerable<Izazovi> Izazovi{ get; set; }
   
        public int IdIzazova { get; set; }
    }
}
