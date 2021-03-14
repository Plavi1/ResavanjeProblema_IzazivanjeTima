using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Korisnik.Models
{
    public class ApplicationKorisnik : IdentityUser
    { 
        // Dodali smo jos 2 tipa koja ce se ubaciti zajedno sa ostalim identity tipovima 

        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string Ime { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Prezime { get; set; }
        
    }
}
