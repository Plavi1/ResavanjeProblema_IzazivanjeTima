using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Korisnik.Models
{
    public class Ogranicenja
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [ForeignKey("Korisnik")]
        [Required]
        [Column(Order = 1)]
        public string IdKorisnika { get; set; }
        public Korisnici Korisnik { get; set; }

        [Required]
        [Column(Order = 2)]
        public string IdSaKojimOgranicavamKorisnika { get; set; }


    }
}
