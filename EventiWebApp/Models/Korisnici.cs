using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Models
{
    public class Korisnici
    {
        public int? IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }

        public Korisnici(int? id, string ime, string prezime, string korisnickoIme, string lozinka, string email, bool admin)
        {
            IdKorisnik = id;
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Email = email;
            Admin = admin;
        }

    }
}
