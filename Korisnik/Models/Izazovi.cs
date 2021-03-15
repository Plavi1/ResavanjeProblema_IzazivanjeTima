using Korisnik.ViewModel.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Korisnik.Models
{
    public class Izazovi
    {
        [Key]
        [Column(Order = 0)]
        public int IdIzazova { get; set; }

        [ForeignKey("Korisnik")]
        [Required]
        [Column(Order = 1)]
        public string IdIzazivaoca { get; set; }
        public ApplicationKorisnik Korisnik { get; set; }

        [Required]
        [Column(Order = 2)]
        public string IdIzazavanog { get; set; }

        [Column(Order = 3)]
        public string ImeIzazivaoca { get; set; }

        [Column(Order = 4)]
        public string ImeIzazvanog { get; set; }

        [Column(Order = 5)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? VremePoslatogIzazova { get; set; }

        [Column(Order = 6)]      
        public string ZakazanoVreme { get; set; }

        [Column(Order = 7)]
        public string ZakazanDatum { get; set; }

        [Column(Order = 8)]
        public Mesta Mesto { get; set; }

      
    
    }
}