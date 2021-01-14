using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger, 
                              IKorisnikRepository korisnikRepository, 
                              IIzazoviRepository izazoviRepository,
                              UserManager<ApplicationKorisnik> userManager,
                              IPrihvaceni_IzazoviRepository prihvaceniIzazovi)
        {
            this.userManager = userManager;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
            _logger = logger;
        }



        //Prva strana na koju udje korisnik kada se uloguje 

        [HttpGet]
        [Authorize]
        public ViewResult Index(Index_ViewModel model)
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);

            var ulogovanPoslao = izazoviRepository.SviIzazovi().Where(a => a.IdIzazivaoca == idUlogovanog);           //{--  Broj Izaova koje je POSLAO
            model.BrojIzazova = ulogovanPoslao.Count().ToString();                                                    //{--     ulogovani korisnik

            var ulogovanDobio = izazoviRepository.SviIzazovi().Where(c => c.IdIzazavanog == idUlogovanog);            //{--  Broj Izazova koje je DOBIO
            model.IzazvanBroj = ulogovanDobio.Count().ToString();                                                     //{--   od strane drugih korisnika

            var listaSvihPrihvacenihIzazova = prihvaceniIzazovi.SviIzazovi();                                         //{--
            int brojPrihvacenih = 0;                                                                                  //{--
            foreach (var item in listaSvihPrihvacenihIzazova)                                                         //{--
            {                                                                                                         //{--  Broj Prihvacenih izazova koje
                if (item.IdIzazavanog == idUlogovanog || item.IdIzazivaoca == idUlogovanog)                           //{--   je prihvatio korinsink
                {                                                                                                     //{--
                    brojPrihvacenih++;                                                                                //{--
                }                                                                                                     //{--
            }                                                                                                         //{--
            model.BrojPrihvacenih = brojPrihvacenih.ToString();                                                       //{--
                                                               

            return View(model);
        }



        //Privremeni prikaz /home/svetabele ---[GET]---

        [HttpGet]
        public IActionResult SveTabele()                                                      //
        {                                                                                     // 
            SveTabele_ViewModel sveTabele = new SveTabele_ViewModel                           //     PROST PRIKAZ SVIH TABELA IZ Micrsoft SQL Servera
            {                                                                                 //              [PRIVREMENEO  /home/svetable]
                ApplicationKorisnik = korisnikRepository.SviKorisnici(),                      //
                Izazovi = izazoviRepository.SviIzazovi(),                                     //
                PrihvaceniIzazovi = prihvaceniIzazovi.SviIzazovi()                            //
            };                                                                                //
            return View(sveTabele);                                                           //
        }



        //Privremeni prikaz /home/svetabele ----OBRISI IZAZAOV----

        public async Task<IActionResult> ObrisiIzazov(int id)
        {
            
            await izazoviRepository.Delete(id);


            return RedirectToAction("SveTabele");
        }

        //Privremeni prikaz /home/svetabele ----OBRISI PRIHVACEN IZAZOV----

        public async Task<IActionResult> ObrisiPrihvacen(int id)
        {

            await prihvaceniIzazovi.Delete(id);


            return RedirectToAction("SveTabele");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}