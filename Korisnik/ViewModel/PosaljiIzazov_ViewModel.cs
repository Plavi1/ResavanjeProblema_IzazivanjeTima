using Korisnik.Areas.Identity.Data;
using Korisnik.ViewModel.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Korisnik.ViewModel
{
    public class PosaljiIzazov_ViewModel
    {
        public IEnumerable<ApplicationKorisnik> ApplicationKorisnik { get; set; }

        [Required]
        public string IdIzazvanog { get; set; }

         
        [Required(ErrorMessage = "Niste izabrali Datum!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public string Datum { get; set; }


        [Required(ErrorMessage = "Niste izabrali Vreme!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public string Vreme { get; set; }


        [Required(ErrorMessage = "Niste izabrali Mesto!")]
        public Mesta? Mesto { get; set; }


    }
}