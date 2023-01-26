using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EventiWebApp.Controllers
{
    public class KorisnikController : Controller
    {
        public IActionResult Eventi()
        {
            return View();
        }
        public IActionResult KreirajEvent()
        {
            return View();
        }
        public IActionResult UspjesnoKreiranEvent()
        {
            return View();
        }
    }
}
