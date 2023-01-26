using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Models;
using EventiWebApp.Services;
using Newtonsoft.Json.Linq;

namespace EventiWebApp.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private AdminServices _adminService;
        public AdminApiController(AdminServices adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("sveKorisnike")]
        public ActionResult<List<Korisnici>> GetKorisnik()
        {
            if (HttpContext.Session.GetString("admin") != "true")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            var list = _adminService.GetAllKorisnici().ToList();
            return list;
        }

        [HttpDelete("delete/{id}")]
        public void DeleteKorisnik(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return;
            _adminService.DeleteKorisnik(id);
        }

        [HttpGet("sveEvente")]
        public ActionResult<List<Models.Eventi>> GetEvent()
        {
            if (HttpContext.Session.GetString("admin") != "true")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            var list = _adminService.GetAllEventi().ToList();
            return list;
        }

        [HttpDelete("delete/{id}")]
        public void DeleteEvent(int id)
        {
            _adminService.DeleteEvent(id);
        }
    }
}
