using Korisnik.Areas.Identity.Data;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Controllers
{
    [Authorize]
    public class DobijeniController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;

        public DobijeniController(UserManager<ApplicationKorisnik> userManager,                                 
                                  IIzazoviRepository izazoviRepository,
                                  IPrihvaceni_IzazoviRepository prihvaceniIzazovi)
        {
            this.userManager = userManager;
            this.izazoviRepository = izazoviRepository;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
            ;
        }

        [HttpGet]
        public ViewResult Izazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);
            var poslatiIzazoviUlogovanog = izazoviRepository.SviIzazovi().Where(e => e.IdIzazavanog == idUlogovanog);

            DobijeniIzazovi_ViewModel model = new DobijeniIzazovi_ViewModel
            {
                Izazovi = poslatiIzazoviUlogovanog
            };

            return View(model);
        }

        public async Task<IActionResult> Obrisi(int id)
        {
            await izazoviRepository.Delete(id);
            
            return RedirectToAction("Izazov");
        }

        public async Task<IActionResult> Prihvatam(int id)
        {
            var izazov = await izazoviRepository.GetIzazovi(id);

            Prihvaceni_Izazovi novIzazov = new Prihvaceni_Izazovi
            {
                IdIzazavanog = izazov.IdIzazavanog,
                IdIzazivaoca = izazov.IdIzazivaoca,
                ImeIzazivaoca = izazov.ImeIzazivaoca,
                ImeIzazvanog = izazov.ImeIzazvanog,
                Mesto = izazov.Mesto,
                ZakazanoVreme = izazov.ZakazanoVreme,
                ZakazanDatum = izazov.ZakazanDatum
            };

            await prihvaceniIzazovi.AddIzazovi(novIzazov);
            await izazoviRepository.Delete(id);

            return RedirectToAction("Izazov");
        }
    }
}
