using Korisnik.ViewModel.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Korisnik.ViewModel
{
    public class Promeni_ViewModel
    {
        
        public int IdIzazova { get; set; }
        public string IdIzazivaoca { get; set; }
        [Display(Name ="Ime Izazivaoca")]
        public string ImeIzazivaoca { get; set; }
        public string ZakazanoVreme { get; set; }
        public string ZakazanDatum { get; set; }
        [Required(ErrorMessage ="Moras selektovati mesto")]
        public Mesta Mesto { get; set; }
    }
}
