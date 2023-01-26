using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;

namespace EventiWebApp.Repositories
{
    public class PrijavaRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public PrijavaRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }
        public int RegistrirajKorisnika(Models.Korisnici mkorisnik)
        {
            var dbKorisnik = KorisniciMapper.ToDatabase(mkorisnik);
            _dbContext.Korisnicis.Add(dbKorisnik);
            _dbContext.SaveChanges();
            var k = _dbContext.Korisnicis.Where(x => x.KorisnickoIme == mkorisnik.KorisnickoIme).FirstOrDefault();
            return k.IdKorisnik;
        }
        public bool PostojeciKorisnik(string korisnickoIme)
        {
            var dbKor = _dbContext.Korisnicis.Where(x => x.KorisnickoIme.Equals(korisnickoIme)).FirstOrDefault();
            return dbKor != null;
        }
        public Models.Korisnici PrijavaKorisnik(string korisnickoIme, string lozinka)
        {
            var dbKorisnik = _dbContext.Korisnicis.Where(x => (x.KorisnickoIme.Equals(korisnickoIme) && x.Lozinka.Equals(lozinka))).FirstOrDefault();
            if (dbKorisnik == null)
                return null;
            return KorisniciMapper.FromDatabase(dbKorisnik);
        }
    }
}
