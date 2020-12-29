using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Korisnik.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationKorisnik class
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
