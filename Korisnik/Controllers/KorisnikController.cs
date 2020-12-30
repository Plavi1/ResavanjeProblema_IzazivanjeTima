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

            var ruser = userManager.GetUserId(HttpContext.User);                                 // Nalazi ID ulogovanog    
            var lista = korisnikRepository.SviKorisnici().Where(e => e.Id != ruser);             // Svi korisnici izuzev ulogovanog korisnika

            mymodel.ApplicationKorisnik = lista;                                                 // Prebacujemo u nas ViewModel vrednost za ApplicationKorisnik

            return View(mymodel);                                                                // Saljemo ceo ViewModel koji sadrzi sve bitne informacije za nas View
        }


        [HttpPost]
        [Authorize]
        public IActionResult ListaKorisnika(ListaKorisnikaViewModel model)                       // Dolaze nam informacije iz nase forme na View stranci
        {
            
            if (model.IdIzazvanog != "false")                                                    // Nama je samo bitan IdIzazvanog zato proveravamo da li je vrednost "false" da bi nastavili
            {

                Izazovi novIzazov = new Izazovi()                                                // Ako je prosledjen IdIzazvanog automatcki pravimo nov model koji zelimo da ubacimo u Db
                {
                    IdIzazavanog = model.IdIzazvanog,                                            //         Ubacujemo sve vrednosti 
                    IdIzazivaoca = userManager.GetUserId(HttpContext.User),                      //          koje sadrzi nas model
                };
                izazoviRepository.AddIzazovi(novIzazov);                                         // Pozivamo nas Repository da zelim da dodamo nov izazov u bazu podataka
                return RedirectToAction("Index", "Home");                                        // Vracamo se na pocetnu stranu

            }

            var ruser = userManager.GetUserId(HttpContext.User);                                           // Opet nam treba Id logovanog [PROMENITI AKO SE BUDE PONAVLJALO]
            model.ApplicationKorisnik = korisnikRepository.SviKorisnici().Where(e => e.Id != ruser);       // Dodeljivanje vrednosti bez Id logovanog [MOZDA POSTOJI TAG-HELPER KOJI DAJE ISTU VREDNOST]
            model.ErrorPoruka = "Nisi selektovao ni jednog korisnika!";                                    // Ubaceno zato sto ne funkcionise asp-validation-for, [MOGUCE DA NEGDE GRESIM, PRONACI DRUGO RESENJE]


            return View(model);
        }





    }
}