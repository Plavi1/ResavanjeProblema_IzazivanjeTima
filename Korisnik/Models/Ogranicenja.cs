using System.ComponentModel.DataAnnotations;

namespace Korisnik.Areas
{
    public class Ogranicenja
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string IdKorisnika { get; set; }
        [Required]
        public string IdSaKojimOgranicavamKorisnika { get; set; }
    }
}
