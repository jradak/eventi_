using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Services;
using EventiWebApp.Models;

namespace EventiWebApp.Controllers
{
    [Route("api/korisnik")]
    [ApiController]
    public class KorisnikApiController : ControllerBase
    {
        private EventiServices _eventiServices;
        public KorisnikApiController(EventiServices eventiServices)
        {
            _eventiServices = eventiServices;
        }

        [HttpGet]
        public ActionResult<List<Eventi>> Get()
        {
            //var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            //var userId = userInfo.UserId;
            Console.WriteLine("Api");
            return _eventiServices.GetAllEventi().ToList();
        }
    }
}
