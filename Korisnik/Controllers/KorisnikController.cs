using Korisnik.Areas.Identity.Data;
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
    public class KorisnikController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;

        public KorisnikController(UserManager<ApplicationKorisnik> userManager,
                                  IKorisnikRepository korisnikRepository,
                                  IIzazoviRepository izazoviRepository)

        {

            this.userManager = userManager;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
        }


        [HttpGet]
        [Authorize]
        public ViewResult ListaKorisnika()
        {
            ListaKorisnikaViewModel mymodel = new ListaKorisnikaViewModel();
            var ruser = userManager.GetUserId(HttpContext.User);
            var lista = korisnikRepository.SviKorisnici().Where(e => e.Id != ruser);
            mymodel.ApplicationKorisnik = lista;

            return View(mymodel);
        }
        [HttpPost]
        [Authorize]
        public IActionResult ListaKorisnika(ListaKorisnikaViewModel model)
        {
            if (ModelState.IsValid)
            {
                Izazovi novIzazov = new Izazovi()
                {
                    IdIzazavanog = model.IdIzazvanog,
                    IdIzazivaoca = userManager.GetUserId(HttpContext.User),
                };
                izazoviRepository.AddIzazovi(novIzazov);
                return RedirectToAction("Home");
            }

            return View();
        }





    }
}