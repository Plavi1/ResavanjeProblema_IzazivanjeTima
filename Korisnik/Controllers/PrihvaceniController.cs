using Korisnik.Areas.Identity.Data;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Controllers
{
    public class PrihvaceniController : Controller
    {

        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;


        public PrihvaceniController(UserManager<ApplicationKorisnik> userManager,               
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
                    listaSvihPrihvacenihIzazov = listaSvihPrihvacenihIzazov.Where(e => e != item).ToList();     //Imao sam velikih problema sa ovim kodom, nije htelo da uspe bez .ToList() [ISTRAZI ZASTO]
                }
            }

            PrihvaceniIzazovi_ViewModel model = new PrihvaceniIzazovi_ViewModel();
            model.ulogovaniPrihvatio = listaSvihPrihvacenihIzazov;

            return View(model);
        }
    }
}
