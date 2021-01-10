using Korisnik.Areas.Identity.Data;
using Korisnik.Repositorys.IzazoviRepo;
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
    public class PoslatiController : Controller
    {
        private readonly IIzazoviRepository izazoviRepository;
        private readonly UserManager<ApplicationKorisnik> userManager;

        public PoslatiController(IIzazoviRepository izazoviRepository, UserManager<ApplicationKorisnik> userManager)
        {
            this.izazoviRepository = izazoviRepository;
            this.userManager = userManager;
        }



        //Prikaz poslatih izazova koje je korisnik poslao ---[GET]---

        [HttpGet]
        [Authorize]
        public ViewResult Izazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);                                         
            var poslatiIzazoviUlogovanog = izazoviRepository.SviIzazovi().Where(e => e.IdIzazivaoca == idUlogovanog);

            PoslatiIzazoviViewModel model = new PoslatiIzazoviViewModel();            
            model.Izazovi = poslatiIzazoviUlogovanog;
            
            return View(model);
        }

        //Prikaz poslatih izazova koje je korisnik poslao ---[POST]---

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Izazov(PoslatiIzazoviViewModel model)           
        {           
            await izazoviRepository.Delete(model.IdIzazova);

            var idUlogovanog = userManager.GetUserId(HttpContext.User);
            var poslatiIzazoviUlogovanog = izazoviRepository.SviIzazovi().Where(e => e.IdIzazivaoca == idUlogovanog);
            model.Izazovi = poslatiIzazoviUlogovanog;

            return View(model);
        }

    }
}
