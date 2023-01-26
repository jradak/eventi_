using System;
using System.Collections.Generic;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class Eventi
    {
        public Eventi()
        {
            KorisnikEvents = new HashSet<KorisnikEvent>();
        }

        public int IdEvent { get; set; }
        public string Naziv { get; set; }
        public DateTime Vrijeme { get; set; }
        public int Mjesto { get; set; }
        public string Adresa { get; set; }
        public string Cijena { get; set; }
        public int VrstaEventa { get; set; }
        public int Organizator { get; set; }
        public bool OgraniceniPosjetitelji { get; set; }

        public virtual Mjestum MjestoNavigation { get; set; }
        public virtual Korisnici OrganizatorNavigation { get; set; }
        public virtual VrsteEventum VrstaEventaNavigation { get; set; }
        public virtual ICollection<KorisnikEvent> KorisnikEvents { get; set; }
    }
}
