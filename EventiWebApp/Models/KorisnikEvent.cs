using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Models
{
    public class KorisnikEvent
    {
        public int? IdKorisnikEvent { get; set; }
        public int Event { get; set; }
        public int Korisnik { get; set; }
        public bool? Potvrdeno { get; set; }
        public int? Recenzija { get; set; }

        public KorisnikEvent(int? id, int eventi, int korisnik, bool? potvrdeno, int? recenzija)
        {
            IdKorisnikEvent = id;
            Event = eventi;
            Korisnik = korisnik;
            Potvrdeno = potvrdeno;
            Recenzija = recenzija;
        }
    }
}
