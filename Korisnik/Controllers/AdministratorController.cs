using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using Korisnik.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdministratorController : Controller
    {
        private readonly UserManager<ApplicationKorisnik> userManager;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;

        public AdministratorController(IKorisnikRepository korisnikRepository,
                              IIzazoviRepository izazoviRepository,
                              UserManager<ApplicationKorisnik> userManager,
                              IPrihvaceni_IzazoviRepository prihvaceniIzazovi,
                              RoleManager<IdentityRole> roleManager)                            
        {
            this.userManager = userManager;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
            this.roleManager = roleManager;
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

 
                var userClaims = await userManager.GetClaimsAsync(user);
                var userRoles = await userManager.GetRolesAsync(user);

                var model = new EditUser_ViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                    Ime = user.Ime,
                    Prezime = user.Prezime,
                    Claims = userClaims.Select(c => c.Value).ToList(),
                    Roles = userRoles
                };

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
    }   

}
