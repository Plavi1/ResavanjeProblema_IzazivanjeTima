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
    public class DobijeniController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IIzazoviRepository izazoviRepository;

        public DobijeniController(UserManager<ApplicationKorisnik> userManager,                                 
                                  IIzazoviRepository izazoviRepository)
        {
            this.userManager = userManager;
            this.izazoviRepository = izazoviRepository;
        }
        [HttpGet]
        [Authorize]
        public ViewResult Izazov()
        {
            var ruser = userManager.GetUserId(HttpContext.User);
            var filter = izazoviRepository.SviIzazovi().Where(e => e.IdIzazavanog == ruser);
            PoslatiIzazoviViewModel model = new PoslatiIzazoviViewModel();
            model.Izazovi = filter;

            return View(model);
        }
    }
}
