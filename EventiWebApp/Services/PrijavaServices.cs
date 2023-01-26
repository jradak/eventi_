using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Repositories;

namespace EventiWebApp.Services
{
    public class PrijavaServices
    {
        public PrijavaRepository _prijavaRepository;

        public PrijavaServices(PrijavaRepository prijavaRepository)
        {
            _prijavaRepository = prijavaRepository;
        }

        public int RegistrirajKorisnika(Models.Korisnici mkorisnik)
        {
            return _prijavaRepository.RegistrirajKorisnika(mkorisnik);
        }

        public Models.Korisnici VerifyKorisnik(string ime, string prezime, string korisnickoIme, string loz, string loz2, string email)
        {
            if (korisnickoIme == null || ime == null || prezime == null || loz == null || loz2 == null || email == null)
                return null;
            if (korisnickoIme.Length <= 1 || ime.Length <= 1 || prezime.Length <= 1 || loz != loz2 || loz.Length < 5 || email.IndexOf('@') < 3 || email.Length - email.LastIndexOf('.') < 2 || email.Length - email.LastIndexOf('.') > 3)
                return null;

            if (!_prijavaRepository.PostojeciKorisnik(korisnickoIme))
                return new Models.Korisnici(null, ime,prezime, korisnickoIme,loz,email, false);
            return null;
        }

        public Models.Korisnici PrijavaKorisnik(string korisnickoIme, string lozinka)
        {
            return _prijavaRepository.PrijavaKorisnik(korisnickoIme, lozinka);
        }

    }
}
