﻿using Korisnik.Models;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Controllers
{
    [Authorize]
    public class PrihvaceniController : Controller
    {

        private readonly UserManager<Korisnici> userManager;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;


        public PrihvaceniController(UserManager<Korisnici> userManager,               
                                  IPrihvaceni_IzazoviRepository prihvaceniIzazovi)
        {
            this.userManager = userManager;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
        }


        [HttpGet]
        public ViewResult Izazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);
            var listaSvihPrihvacenihIzazov = prihvaceniIzazovi.SviIzazovi();
            
            
            foreach (var item in listaSvihPrihvacenihIzazov)
            { 
                if (item.IdIzazavanog != idUlogovanog && item.IdIzazivaoca != idUlogovanog)
                {
                    listaSvihPrihvacenihIzazov = listaSvihPrihvacenihIzazov.Where(e => e != item).ToList();     // Imao sam velikih problema sa ovim kodom, nije htelo da uspe bez .ToList() [ISTRAZI ZASTO]
                }                                                                                               // Zato sto je .ToList() immediate operator, to jest query se izvrsava odma cim ga pozovemo
            }                                                                                                   // Ako ti nije jasno pogledaj LINQ 

            PrihvaceniIzazovi_ViewModel model = new PrihvaceniIzazovi_ViewModel();
            model.ulogovaniPrihvatio = listaSvihPrihvacenihIzazov;

            return View(model);
        }
    }
}
