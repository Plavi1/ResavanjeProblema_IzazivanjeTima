﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.ViewModel
{
    public class EditUser_ViewModel
    {
            public EditUser_ViewModel()
            {
                Claims = new List<string>();
                Roles = new List<string>();
            }

            public string Id { get; set; }

            [Required]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Ime { get; set; }
            [Required]
            public string Prezime { get; set; }

            public List<string> Claims { get; set; }

            public IList<string> Roles { get; set; }  
    }
}
