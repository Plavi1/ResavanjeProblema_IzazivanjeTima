using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.ViewModel
{
    public class CreateRole_ViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
