using Korisnik.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Models
{ 
    public class Izazovi
    {
        [Key]
        [Column(Order = 0)]
        public int IdIzazova { get; set; }


        [Required]
        [Column(Order = 1)]
        public string IdIzazivaoca { get; set; }


        [Required]
        [Column(Order = 2)]
        public string IdIzazavanog { get; set; }


        [Column(Order = 3)]
        public string ImeIzazivaoca { get; set; }


        [Column(Order = 4)]
        public string ImeIzazvanog { get; set; }








    }
}