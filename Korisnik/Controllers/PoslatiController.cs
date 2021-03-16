using Korisnik.Models;
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
    [Authorize]
    public class PoslatiController : Controller
    {
        private readonly IIzazoviRepository izazoviRepository;
        private readonly UserManager<Korisnici> userManager;

        public PoslatiController(IIzazoviRepository izazoviRepository, UserManager<Korisnici> userManager)
        {
            this.izazoviRepository = izazoviRepository;
            this.userManager = userManager;
        }



        //Prikaz poslatih izazova koje je korisnik poslao ---[GET]---

        [HttpGet]
        public ViewResult Izazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);                                         
            var poslatiIzazoviUlogovanog = izazoviRepository.SviIzazovi().Where(e => e.IdIzazivaoca == idUlogovanog);

            PoslatiIzazovi_ViewModel model = new PoslatiIzazovi_ViewModel();            
            model.Izazovi = poslatiIzazoviUlogovanog;
            
            return View(model);
        }

        //Prikaz poslatih izazova koje je korisnik poslao ---[POST]---

        [HttpPost]
        public async Task<IActionResult> Izazov(PoslatiIzazovi_ViewModel model)           
        {           
            await izazoviRepository.Delete(model.IdIzazova);
            TempData["obavestenje"] = "Izazov je obrisan!";

            return RedirectToAction("Izazov");
        }

    }
}
