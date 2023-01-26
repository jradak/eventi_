using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;

namespace EventiWebApp.Mappers
{
    public class KorisniciMapper
    {
        public static Korisnici FromDatabase(DbModels.Korisnici k)
        {
            return new Korisnici(k.IdKorisnik, k.Ime, k.Prezime, k.KorisnickoIme, k.Lozinka, k.Email, k.Admin);
        }
        public static DbModels.Korisnici ToDatabase(Korisnici k)
        {
            DbModels.Korisnici x = new DbModels.Korisnici
            {
                Ime = k.Ime,
                Prezime = k.Prezime,
                KorisnickoIme = k.KorisnickoIme,
                Lozinka = k.Lozinka,
                Email = k.Email

            };
            if (k.IdKorisnik != null)
            {
                x.IdKorisnik = (int)k.IdKorisnik;
            }
            return x;
        }

    }
}
