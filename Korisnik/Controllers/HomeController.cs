using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger, 
                              IKorisnikRepository korisnikRepository, 
                              IIzazoviRepository izazoviRepository)
        {
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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