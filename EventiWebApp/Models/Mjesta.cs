using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Models
{
    public class Mjesta
    {
        public int? IdMjesto { get; set; }
        public string Naziv { get; set; }
        
        public Mjesta(int? id, string naziv)
        {
            IdMjesto = id;
            Naziv = naziv;
        }
    }
}
