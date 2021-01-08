using Korisnik.Areas.Identity.Data;
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
    public class PoslatiController : Controller
    {
        private readonly IIzazoviRepository izazoviRepository;
        private readonly UserManager<ApplicationKorisnik> userManager;

        public PoslatiController(IIzazoviRepository izazoviRepository, UserManager<ApplicationKorisnik> userManager)
        {
            this.izazoviRepository = izazoviRepository;
            this.userManager = userManager;
        }


        [HttpGet]
        [Authorize]
        public ViewResult Izazov()
        {
            var ruser = userManager.GetUserId(HttpContext.User);
            var filter = izazoviRepository.SviIzazovi().Where(e => e.IdIzazivaoca == ruser);
            PoslatiIzazoviViewModel model = new PoslatiIzazoviViewModel();            
            model.Izazovi = filter;
            
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Izazov(PoslatiIzazoviViewModel model)           
        {           
            await izazoviRepository.Delete(model.IdIzazova);

            var ruser = userManager.GetUserId(HttpContext.User);
            var filter = izazoviRepository.SviIzazovi().Where(e => e.IdIzazivaoca == ruser);
            model.Izazovi = filter;

            return View(model);
        }

    }
}
