using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Services;

namespace EventiWebApp.Controllers
{
    public class PrijavaController : Controller
    {
        
        public IActionResult Prijava()
        {
            return View();
        }
        public IActionResult Registracija()
        {
            return View();
        }
    }
}
