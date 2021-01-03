using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger, 
                              IKorisnikRepository korisnikRepository, 
                              IIzazoviRepository izazoviRepository,
                              UserManager<ApplicationKorisnik> userManager)
        {
            this.userManager = userManager;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
            _logger = logger;
        }
        [HttpGet]
        public ViewResult Index(IndexViewModel model)
        {
            var ruser = userManager.GetUserId(HttpContext.User);
            var izazovi = izazoviRepository.SviIzazovi().Where(a => a.IdIzazivaoca == ruser);
            model.BrojIzazova = izazovi.Count().ToString();

            return View(model);
        }
        [HttpGet]
        public IActionResult SveTabele()                                                      //
        {                                                                                     // 
            SveTabele sveTabele = new SveTabele                                               //     PROST PRIKAZ SVIH TABELA IZ Micrsoft SQL Servera
            {                                                                                 //              [PRIVREMENEO  /home/svetable]
                ApplicationKorisnik = korisnikRepository.SviKorisnici(),                      //
                Izazovi = izazoviRepository.SviIzazovi()                                      // 
            };                                                                                //
            return View(sveTabele);                                                           //
        }
        [HttpPost]
        public IActionResult SveTabele(SveTabele sve)
        {
            
            izazoviRepository.Delete(sve.id);

            SveTabele sveTabele = new SveTabele                                              
            {                                                                                
                ApplicationKorisnik = korisnikRepository.SviKorisnici(),                      
                Izazovi = izazoviRepository.SviIzazovi()                                      
            };

            return View(sveTabele);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}