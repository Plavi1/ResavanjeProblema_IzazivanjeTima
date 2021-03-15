using Korisnik.Models;
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
            TempData["obavestenje"] = "Izazov je odbijen!";

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
            TempData["obavestenje"] = "Izazov je prihvacen!";

            return RedirectToAction("Izazov");
        }
    
        [HttpGet]
        public async Task<IActionResult> Promeni(int id)
        {
            var izazov = await izazoviRepository.GetIzazovi(id);

            if (izazov == null)
            {
                ViewBag.ErrorMessage = $"Izazov nije pronadjen ";
                return View("NotFound");
            }
            if(izazov.IdIzazavanog == userManager.GetUserId(User))
            {
            Promeni_ViewModel model = new Promeni_ViewModel
                        {
                            ImeIzazivaoca = izazov.ImeIzazivaoca,
                            IdIzazova = izazov.IdIzazova,
                            IdIzazivaoca = izazov.IdIzazivaoca,
                            Mesto = izazov.Mesto,
                            ZakazanoVreme = izazov.ZakazanoVreme,
                            ZakazanDatum = izazov.ZakazanDatum
                        };

             return View(model);
            }
            ViewBag.ErrorMessage = $"Izazov nije pronadjen ";
            return View("NotFound");
        }
        [HttpPost]
        public async Task<IActionResult> Promeni(Promeni_ViewModel model)
        {
           
                if (ModelState.IsValid)
                {
                    var izazov = await izazoviRepository.GetIzazovi(model.IdIzazova);
                    if (izazov == null)
                    {
                        ViewBag.ErrorMessage = $"Izazov nije pronadjen ";
                        return View("NotFound");
                    }

                    izazov.IdIzazivaoca = userManager.GetUserId(User);
                    izazov.ImeIzazivaoca = userManager.GetUserAsync(User).Result.Ime;
                    izazov.IdIzazavanog = model.IdIzazivaoca;
                    izazov.ImeIzazvanog = model.ImeIzazivaoca;
                    izazov.Mesto = model.Mesto;
                    izazov.ZakazanDatum = model.ZakazanDatum;
                    izazov.ZakazanoVreme = model.ZakazanoVreme;

                    await izazoviRepository.UpdateIzazovi(izazov);
                    TempData["message"] = "Promene su poslate korisniku!";

                    return RedirectToAction("Index", "Home");
                }
                return View(model);
          
        }
    }
}
