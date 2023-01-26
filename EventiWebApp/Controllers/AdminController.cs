using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EventiWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Korisnici()
        {
            return View();
        }
        public IActionResult Eventi()
        {
            return View();
        }
    }
}
