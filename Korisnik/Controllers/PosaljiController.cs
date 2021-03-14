using Korisnik.Areas;
using Korisnik.Filteri;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
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
    public class PosaljiController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly IFilter filteri;
        

        public PosaljiController(UserManager<ApplicationKorisnik> userManager,
                                  IKorisnikRepository korisnikRepository,
                                  IIzazoviRepository izazoviRepository,
                                  IFilter filteri)
        {
            this.userManager = userManager;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
            this.filteri = filteri;

        }


        //LISTA IZAZOVA ---[GET]---

        [HttpGet]    
        public ViewResult Izazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);                                    // Nalazi ID ulogovanog

            PosaljiIzazov_ViewModel mymodel = new PosaljiIzazov_ViewModel();

            IEnumerable<ApplicationKorisnik> lista = filteri.PosaljiIzazovFilterTabele(idUlogovanog);      // Metoda gore navedena  
            
            mymodel.ApplicationKorisnik = lista;                                                           // Prebacujemo u nas ViewModel vrednost za ApplicationKorisnik

            return View(mymodel);                                                                          // Saljemo ceo ViewModel koji sadrzi sve bitne informacije za nas View
        }



        //LISTA IZAZOVA ---[POST]---

        [HttpPost]
        public async Task<IActionResult> Izazov(PosaljiIzazov_ViewModel model)                    
        {

            var idUlogovanog = userManager.GetUserId(HttpContext.User);


            if (model.IdIzazvanog == "false")
            {                                                                                    //
                ModelState.AddModelError("IdIzazvanog", "Niste izabrao Korisnika!");             // Ako ne selektujemo checkbox docice nam vrednost "falls" (stringu), zato ubacujemo Error u ModelState
            }                                                                                    //               on ce spreciti ubacivanje podataka i izabacice Validation za cekiranje
            else
            {
                ModelState.Remove("IdIzazvanog");                                                // Ako je cekiran checkbox, onda moramo da izuzmemo ModelState za IdIzazvanog jer ce nam             
            }                                                                                    //  pri proveri u sledecem koraku proveravati ModelState, i na kraju ce izbaciti error (string umesto bool)

           
            
            if (ModelState.IsValid)                                                                
            {
                var Izazvani = await korisnikRepository.GetKorisnik(model.IdIzazvanog);
                var ImeIzazvanog = Izazvani.Ime;

                Izazovi novIzazov = new Izazovi()                                                 // Ako je prosledjen IdIzazvanog automatcki pravimo nov model koji zelimo da ubacimo u bazu podataka
                {
                    IdIzazavanog = model.IdIzazvanog,                                             // <--        
                    IdIzazivaoca = idUlogovanog,                                                  // <--        Ubacujemo sve vrednosti
                    ImeIzazvanog = ImeIzazvanog,                                                  // <--         koje sadrzi nas model
                    ImeIzazivaoca = korisnikRepository.GetKorisnik(idUlogovanog).Result.Ime,      // <--
                    VremePoslatogIzazova = DateTime.Now,                                          // <--
                    Mesto = model.Mesto.ToString(),                                               // <--
                    ZakazanDatum = model.Datum,                                                   // <--
                    ZakazanoVreme = model.Vreme                                                   // <--

                };
                await izazoviRepository.AddIzazovi(novIzazov);                                   // Pozivamo nas Repository da zelim da dodamo nov izazov u bazu podataka
                return RedirectToAction("Index", "Home");                                        // Vracamo se na pocetnu stranu
            }

            
            //Treba napraviti klasu koja ce pozivati ovaj filter za tabelu, da bi mogli da pozovemo metodu u PosaljiIzazov_VievModel

            IEnumerable<ApplicationKorisnik> lista = filteri.PosaljiIzazovFilterTabele(idUlogovanog);

            PosaljiIzazov_ViewModel ponovo = new PosaljiIzazov_ViewModel {
                ApplicationKorisnik = lista,                                                 //{ --  Dodeljujemo ViewModelu   
            };
            
            return View(ponovo);

        }
    }
}