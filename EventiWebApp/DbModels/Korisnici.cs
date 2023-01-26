using System;
using System.Collections.Generic;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            Eventis = new HashSet<Eventi>();
            KorisnikEvents = new HashSet<KorisnikEvent>();
        }

        public int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }

        public virtual ICollection<Eventi> Eventis { get; set; }
        public virtual ICollection<KorisnikEvent> KorisnikEvents { get; set; }
    }
}
