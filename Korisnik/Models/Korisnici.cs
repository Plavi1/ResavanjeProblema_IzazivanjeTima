using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Korisnik.Models
{
    public class Korisnici : IdentityUser
    { 
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string Ime { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Prezime { get; set; }

    }
}
