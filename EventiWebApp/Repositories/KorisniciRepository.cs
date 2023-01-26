using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.EntityFrameworkCore;

namespace EventiWebApp.Repositories
{
    public class KorisniciRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public KorisniciRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }

        public IEnumerable<Models.KorisnikEvent> GetAllMyEvents(int id)
        {
            return _dbContext.KorisnikEvents.Include(c => c.IdKorisnikEvent)
                                            .Include(c => c.Event)
                                            .Where(c => c.Korisnik.Equals(id))
                                            .Select(c => KorisnikEventiMapper.FromDatabase(c));
        }
        public IEnumerable<Models.Eventi> GetAllMyEvent(int id)
        {
            return _dbContext.Eventis.Include(c => c.IdEvent)
                                            .Include(c => c.Mjesto)
                                            .Include(c => c.VrstaEventa)
                                            .Where(c => c.Organizator.Equals(id))
                                            .Select(c => EventiMapper.FromDatabase(c));
        }
        public int CreateEvent(Models.Eventi e)
        {
            var dbEventi = EventiMapper.ToDatabase(e);
            _dbContext.Eventis.Add(dbEventi);
            _dbContext.SaveChanges();
            var k = _dbContext.Eventis.Where(x => x.IdEvent == e.IdEvent).FirstOrDefault();
            return k.IdEvent;

        }
        public void DeleteMyEvent(int id)
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
        public void PrijavaNaEvent()
        {
        }

    }
}
