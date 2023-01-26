using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;

namespace EventiWebApp.Repositories
{
    public class AdminRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public AdminRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }
        public IEnumerable<Models.Korisnici> GetAllKorisnici()
        {
            var db = _dbContext.Korisnicis.Where(x => x.Admin == false);
            var list = _dbContext.Korisnicis.Where(x => x.Admin == false).Select(x => KorisniciMapper.FromDatabase(x));
            return list;
        }
        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            var db = _dbContext.Eventis;
            var list = _dbContext.Eventis.Where(x => x.Vrijeme >= DateTime.Today).Select(x => EventiMapper.FromDatabase(x));
            return list;
        }
        public void DeleteKorisnik(int id)
        {
            while (_dbContext.Eventis.Where(x => x.Organizator.Equals(id)).FirstOrDefault() != null)
            {
                var kk = _dbContext.Eventis.Where(x => x.Organizator.Equals(id)).FirstOrDefault();
                _dbContext.Eventis.Remove(kk);
                _dbContext.SaveChanges();
            }
            while (_dbContext.KorisnikEvents.Where(x => x.Korisnik.Equals(id)).FirstOrDefault() != null)
            {
                var kk = _dbContext.KorisnikEvents.Where(x => x.Korisnik.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(kk);
                _dbContext.SaveChanges();
            }
            var korisnik = _dbContext.Korisnicis.Where(x => x.IdKorisnik == id).FirstOrDefault();
            _dbContext.Korisnicis.Remove(korisnik);
            _dbContext.SaveChanges();
        }
        public void DeleteEvent(int id)
        {
            while (_dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault() != null)
            {
                var kk = _dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(kk);
                _dbContext.SaveChanges();
            }
            var event_ = _dbContext.Eventis.Where(x => x.IdEvent == id).FirstOrDefault();
            _dbContext.Eventis.Remove(event_);
            _dbContext.SaveChanges();
        }

    }
}
