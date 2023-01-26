using System;
using System.Collections.Generic;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class KorisnikEvent
    {
        public int IdKorisnikEvent { get; set; }
        public int Event { get; set; }
        public int Korisnik { get; set; }
        public bool? Potvrdeno { get; set; }
        public int? Recenzija { get; set; }

        public virtual Eventi EventNavigation { get; set; }
        public virtual Korisnici KorisnikNavigation { get; set; }
    }
}
