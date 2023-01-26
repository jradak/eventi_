using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Models
{
    public class Eventi
    {
        public int? IdEvent { get; set; }
        public string Naziv { get; set; }
        public DateTime Vrijeme { get; set; }
        public int Mjesto { get; set; }
        public string Adresa { get; set; }
        public string Cijena { get; set; }
        public int VrstaEventa { get; set; }
        public int Organizator { get; set; }
        public bool OgraniceniPosjetitelji { get; set; }

        public Eventi(int? id, string naziv, DateTime vrijeme, int mjesto, string adresa, string cijena, int vrstaEventa, int organizator, bool ograniceniPosjetitelji)
        {
            IdEvent = id;
            Naziv = naziv;
            Vrijeme = vrijeme;
            Mjesto = mjesto;
            Adresa = adresa;
            Cijena = cijena;
            VrstaEventa = vrstaEventa;
            Organizator = organizator;
            OgraniceniPosjetitelji = ograniceniPosjetitelji;
        }
    }
}
