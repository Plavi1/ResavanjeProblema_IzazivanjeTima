﻿using Korisnik.Models;
using Korisnik.Filteri;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.OgranicenjaRepo;
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
    [Authorize(Roles = "SuperAdmin")]
    public class AdministratorController : Controller
    {
        private readonly UserManager<Korisnici> userManager;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IOgranicenjaRepository ogranicenjaRepository;
        private readonly IFilter filteri;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;

        public AdministratorController(IKorisnikRepository korisnikRepository,
                              IIzazoviRepository izazoviRepository,
                              UserManager<Korisnici> userManager,
                              IPrihvaceni_IzazoviRepository prihvaceniIzazovi,
                              RoleManager<IdentityRole> roleManager, 
                              IOgranicenjaRepository ogranicenjaRepository,
                              IFilter filteri)                            
        {
            this.userManager = userManager;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
            this.roleManager = roleManager;
            this.ogranicenjaRepository = ogranicenjaRepository;
            this.filteri = filteri;
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
        }

            //---------------------------------------------SVE TABELE--------------------------------------------------------------------------------------------------

            //SVE TABELE [GET]

            [HttpGet]
            public IActionResult SveTabele()                                                      
            {                                                                                     
                SveTabele_ViewModel sveTabele = new SveTabele_ViewModel                                                        //     PROST PRIKAZ SVIH TABELA IZ Micrsoft SQL Servera
                {                                                                                                              //              [PRIVREMENEO  /home/svetable]
                    ApplicationKorisnik = korisnikRepository.SviKorisnici().Where(e => e.UserName != "Admin@admin.com"),       //
                    Izazovi = izazoviRepository.SviIzazovi(),                                                                  //
                    PrihvaceniIzazovi = prihvaceniIzazovi.SviIzazovi()                                                         //
                };                                                                                                             //
                return View(sveTabele);                                                                                        //
            }
   
            //  ----OBRISI IZAZAOV----

            public async Task<IActionResult> ObrisiIzazov(int id)
            {
                var izazov = await izazoviRepository.GetIzazovi(id);

                if (izazov == null)
                {
                    ViewBag.ErrorMessage = $"Izazov sa Id-jem = {id} nije pronadjen";
                    return View("NotFound");
                }
                else
                {
                    await izazoviRepository.Delete(id);
                    return RedirectToAction("SveTabele");
                }
        
            }

            // ---OBRISI PRIHVACEN IZAZOV----

            public async Task<IActionResult> ObrisiPrihvacen(int id)
            {
                var izazov = await prihvaceniIzazovi.GetIzazovi(id);

                if (izazov == null)
                {
                    ViewBag.ErrorMessage = $"Prihvaceni izazov sa Id-jem = {id} nije pronadjen";
                    return View("NotFound");
                }
                else
                {
                    await prihvaceniIzazovi.Delete(id);
                    return RedirectToAction("SveTabele");
                }
            }
            //------------------------------------------------------------------USERS-------------------------------------------------------------------------------------

            // EDIT USER [GET]

            [HttpGet]
            public async Task<IActionResult> EditUser(string id)
            {
                var user = await userManager.FindByIdAsync(id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                    return View("NotFound");
                }



                var model = new EditUser_ViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                    Ime = user.Ime,
                    Prezime = user.Prezime,
                };
                model.Ogranicenja = ogranicenjaRepository.SvaOgranicenja().Where(e => e.IdKorisnika == user.Id).Select(e=> e.IdSaKojimOgranicavamKorisnika).ToList();
                return View(model);
            }

            //EDIT USER [POST]

            [HttpPost]
            public async Task<IActionResult> EditUser(EditUser_ViewModel model)
            {
                var user = await userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                    user.Ime = model.Ime;
                    user.Prezime = model.Prezime;

                    var result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("SveTabele");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            } 

            //DELETE USER 

            [HttpPost]
            public async Task<IActionResult> DeleteUser(string id)
            {
                var user = await userManager.FindByIdAsync(id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var result = await userManager.DeleteAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("SveTabele");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("SveTabele");
                }
            }
            // ----------------------------------------------ROLES-------------------------------------------------------------------------------------------------------


            // CREATE ROLE [GET]

            [HttpGet]
            public IActionResult CreateRole()
            {
                return View();
            }

            // CREATE ROLE [POST]

            [HttpPost]
            public async Task<IActionResult> CreateRole(CreateRole_ViewModel model)
            {
                if (ModelState.IsValid)
                {
                    IdentityRole identityRole = new IdentityRole
                    {
                        Name = model.RoleName
                    };
                    IdentityResult result = await roleManager.CreateAsync(identityRole);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(model);
            }


            //LIST ROLES 

            [HttpGet]
            public IActionResult ListRoles()
            {
                var roles = roleManager.Roles.Where(e=> e.Name != "SuperAdmin");
                return View(roles);
            }

            //EDIT ROLE [GET] 

            [HttpGet]
            public async Task<IActionResult> EditRole(string id)
            {
                var role = await roleManager.FindByIdAsync(id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role sa Id = {id} nepostoji";
                    return View("NotFound");
                }
                var model = new EditRole_ViewModel
                {
                    Id = role.Id,
                    RoleName = role.Name
                };
                foreach (var user in userManager.Users)
                {
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        model.Users.Add(user.UserName);
                    }
                }
                return View(model);
            }

            // EDIT ROLE [POST]

            [HttpPost]
            public async Task<IActionResult> EditRole(EditRole_ViewModel model)
            {
                var role = await roleManager.FindByIdAsync(model.Id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role sa Id = {model.Id} nepostoji";
                    return View("NotFound");
                }
                else
                {
                    role.Name = model.RoleName;
                    var result = await roleManager.UpdateAsync(role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            // EDIT USERS IN ROLE [GET]

            [HttpGet]
            public async Task<IActionResult> EditUsersInRole(string roleId)
            {
                ViewBag.roleId = roleId;

                var role = await roleManager.FindByIdAsync(roleId);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                    return View("NotFound");
                }

                var model = new List<UserRole_ViewModel>();

                foreach (var user in userManager.Users)
                {
                    var userRoleViewModel = new UserRole_ViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName
                    };

                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        userRoleViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRoleViewModel.IsSelected = false;
                    }

                    model.Add(userRoleViewModel);
                }

                return View(model);
            }

            // EDIT USERS IN ROLE [POST]

            [HttpPost]
            public async Task<IActionResult> EditUsersInRole(List<UserRole_ViewModel> model, string roleId)
            {
                var role = await roleManager.FindByIdAsync(roleId);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                    return View("NotFound");
                }

                for (int i = 0; i < model.Count; i++)
                {
                    var user = await userManager.FindByIdAsync(model[i].UserId);

                    IdentityResult result = null;

                    if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                    {
                        result = await userManager.AddToRoleAsync(user, role.Name);
                    }
                    else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                    {
                        result = await userManager.RemoveFromRoleAsync(user, role.Name);
                    }
                    else
                    {
                        continue;
                    }

                    if (result.Succeeded)
                    {
                        if (i < (model.Count - 1))
                            continue;
                        else
                            return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }

                return RedirectToAction("EditRole", new { Id = roleId });
            }

            // DELETE ROLE

            [HttpPost]
            public async Task<IActionResult> DeleteRole(string id)
            {
                var role = await roleManager.FindByIdAsync(id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var result = await roleManager.DeleteAsync(role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("ListRoles");
                }
            }


        // ----------------------------------------------OGRANICAVANJE KORISNIKA-------------------------------------------------------------------------------------------------------


        // GET OgraniciKorisnika

        [HttpGet]
        public async Task<IActionResult> OgraniciKorisnika(string ograniciId)
        {
            ViewBag.ogranici = ograniciId;

            var korisnik = await korisnikRepository.GetKorisnik(ograniciId);                              

            if (korisnik == null)             
            {
                ViewBag.ErrorMessage = $"Korisnik sa Id = {ograniciId} nije pronadjen";
                return View("NotFound");
            }
                                                                                                          
            var model = new List<OgranicenKorisnik_ViewModel>();
            var ogranicenja = ogranicenjaRepository.SvaOgranicenja().Where(e=> e.IdKorisnika == ograniciId);
            var korisnici = korisnikRepository.SviKorisnici().Where(e => e.UserName != "Admin@admin.com" && e.Id != ograniciId)
                                                             .Select(user=> new {UserName=user.UserName,UserId=user.Id}).ToList();

            foreach (var user in korisnici)
            {
                var ogranicenKorisnikViewModel = new OgranicenKorisnik_ViewModel
                {
                    UserId = user.UserId,
                    UserName = user.UserName
                };

                if (ogranicenja.Where(e => e.IdSaKojimOgranicavamKorisnika == user.UserId).Any())
                {
                    ogranicenKorisnikViewModel.IsSelected = true;
                }
                else
                {
                    ogranicenKorisnikViewModel.IsSelected = false;
                }

                model.Add(ogranicenKorisnikViewModel);
            }
            
            return View(model);
        }


       // POST Ogranici Korisnika

        [HttpPost]
        public async Task<IActionResult> OgraniciKorisnika(List<OgranicenKorisnik_ViewModel> model, string ograniciId)
        {
            var korisnik = korisnikRepository.GetKorisnik(ograniciId);

            if (korisnik == null)
            {
                ViewBag.ErrorMessage = $"Korisnik sa = {ograniciId} ne postoji";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)                                                                                         
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);
                var idOgranicenja = ogranicenjaRepository.SvaOgranicenja().Where(e => e.IdSaKojimOgranicavamKorisnika == model[i].UserId && e.IdKorisnika == ograniciId).Select(e => e.Id);  //PROBAJ SA .Single()
                                                                                                                                                                                             
                int a = 0;
                if (idOgranicenja.Any())
                {
                    a++;
                }
     
                if (model[i].IsSelected && a == 0)                  
                {
                    Ogranicenja ogranici = new Ogranicenja { IdKorisnika = ograniciId, IdSaKojimOgranicavamKorisnika = user.Id };
                    await ogranicenjaRepository.AddOgranicenje(ogranici);                                  
                  
                }
                else if (!model[i].IsSelected && a==1)                    
                {
                    await ogranicenjaRepository.Delete(idOgranicenja.First());                      
                   
                }
                else
                {
                    continue;                                                                              
                }
                    if (i < (model.Count - 1))                                                         
                        continue;
                    else
                        return RedirectToAction("EditUser", new { Id = ograniciId });                        
            }

            return RedirectToAction("EditUser", new { Id = ograniciId });
        }


        // ----------------------------------------------NAPRAVI IZAZOV-------------------------------------------------------------------------------------------------------


        //GET Napravi Izazov

        [HttpGet]
        public ViewResult NapraviIzazov()
        {
            var idUlogovanog = userManager.GetUserId(HttpContext.User);                                  

            NapraviIzazov_ViewModel mymodel = new NapraviIzazov_ViewModel();

            IEnumerable<Korisnici> lista = filteri.PosaljiIzazovFilterTabele(idUlogovanog);     

            mymodel.ApplicationKorisnik = lista;                                                          

            return View(mymodel);                                                                          
        }



        //POST Napravi Izazov

        [HttpPost]
        public async Task<IActionResult> NapraviIzazov(NapraviIzazov_ViewModel model)
        {

            if (model.IdIzazvanog == model.IdIzazivaoca)
            {                                                                                 
                ModelState.AddModelError("IdIzazvanog", "Izabrali ste istog Korisnika!");             
            }                                                                                    
           

            if (ModelState.IsValid)
            {
                var Izazvani = await korisnikRepository.GetKorisnik(model.IdIzazvanog);
                var ImeIzazvanog = Izazvani.Ime;

                Prihvaceni_Izazovi novIzazov = new Prihvaceni_Izazovi()                                                
                {
                    IdIzazavanog = model.IdIzazvanog,                                                
                    IdIzazivaoca = model.IdIzazivaoca,                                                 
                    ImeIzazvanog = ImeIzazvanog,                                                  
                    ImeIzazivaoca = korisnikRepository.GetKorisnik(model.IdIzazivaoca).Result.Ime,     
                    VremePoslatogIzazova = DateTime.Now,                                          
                    Mesto = model.Mesto.Value,                                              
                    ZakazanDatum = model.Datum,                                                   
                    ZakazanoVreme = model.Vreme         
                };

                await prihvaceniIzazovi.AddIzazovi(novIzazov);                               
                return RedirectToAction("Index", "Home");                                     
            }

            var idUlogovanog = userManager.GetUserId(HttpContext.User);
            IEnumerable<Korisnici> lista = filteri.PosaljiIzazovFilterTabele(idUlogovanog);

            NapraviIzazov_ViewModel ponovo = new NapraviIzazov_ViewModel
            {
                ApplicationKorisnik = lista,                                                 
            };

            return View(ponovo);

        }

    }

}
