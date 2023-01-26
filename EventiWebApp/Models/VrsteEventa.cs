using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Models
{
    public class VrsteEventa
    {
        public int? IdVrsta { get; set; }
        public string Naziv { get; set; }

        public VrsteEventa(int? id, string naziv)
        {
            IdVrsta = id;
            Naziv = naziv;
        }
    }
}
