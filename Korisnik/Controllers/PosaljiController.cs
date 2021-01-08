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
    public class PosaljiController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;

        public PosaljiController(UserManager<ApplicationKorisnik> userManager,
                                  IKorisnikRepository korisnikRepository,
                                  IIzazoviRepository izazoviRepository)
        {
            this.userManager = userManager;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
        }
        private IEnumerable<ApplicationKorisnik> FilterPrikaza()                                 // Metoda koja se ponavlja, cilj joj je da filtrira prikaz
        {
            var ruser = userManager.GetUserId(HttpContext.User);                                 // Nalazi ID ulogovanog    
            var lista = korisnikRepository.SviKorisnici().Where(e => e.Id != ruser);             // Svi korisnici izuzev ulogovanog korisnika
            var izazovi = izazoviRepository.SviIzazovi().Where(a => a.IdIzazivaoca == ruser);    // Svi izazovi gde se Id ulogovanog slaze sa Id-jem izazivaoca 

            foreach (var item in izazovi)                                                        // {--
            {                                                                                    // {--   Metoda koja filterise sve ID-jeve izazvanih
                lista = lista.Where(e => e.Id != item.IdIzazavanog);                             // {--    koje je ulogovani izazvao
            }                                                                                    // {--
            
            return lista;
        }


        [HttpGet]
        [Authorize]
        public ViewResult Izazov()
        {
            PosaljiIzazovViewModel mymodel = new PosaljiIzazovViewModel();

            IEnumerable<ApplicationKorisnik> lista = FilterPrikaza();                            // Metoda gore navedena  
            
            mymodel.ApplicationKorisnik = lista;                                                 // Prebacujemo u nas ViewModel vrednost za ApplicationKorisnik

            return View(mymodel);                                                                // Saljemo ceo ViewModel koji sadrzi sve bitne informacije za nas View
        }

     

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Izazov(PosaljiIzazovViewModel model)           // Dolaze nam informacije iz nase forme na View stranci
        {         
                  
            if (model.IdIzazvanog != "false")                                                    // Nama je samo bitan IdIzazvanog zato proveravamo da li je vrednost "false" da bi nastavili
            {
                var idUlogovanog = userManager.GetUserId(HttpContext.User);

                var Izazvani = await korisnikRepository.GetKorisnik(model.IdIzazvanog);
                var ImeIzazvanog = Izazvani.Ime;

                Izazovi novIzazov = new Izazovi()                                                // Ako je prosledjen IdIzazvanog automatcki pravimo nov model koji zelimo da ubacimo u Db
                {
                    IdIzazavanog = model.IdIzazvanog,                                            // <--        
                    IdIzazivaoca = idUlogovanog,                                                 // <--        Ubacujemo sve vrednosti
                    ImeIzazvanog = ImeIzazvanog,                                           // <--         koje sadrzi nas model
                    ImeIzazivaoca = korisnikRepository.GetKorisnik(idUlogovanog).Result.Ime      // <--
                    
                };
                await izazoviRepository.AddIzazovi(novIzazov);                                         // Pozivamo nas Repository da zelim da dodamo nov izazov u bazu podataka
                return RedirectToAction("Index", "Home");                                        // Vracamo se na pocetnu stranu

            }

            IEnumerable<ApplicationKorisnik> lista = FilterPrikaza();                            // Metoda gore navedena
            model.ApplicationKorisnik = lista;                                                   //{ --    Dodeljujemo ViewModelu 
            model.ErrorPoruka = "Nisi selektovao ni jednog korisnika!";                          //{ --  Ubaceno zato sto ne funkcionise asp-validation-for, [MOGUCE DA NEGDE GRESIM, PRONACI DRUGO RESENJE]


            return View(model);
        }





    }
}