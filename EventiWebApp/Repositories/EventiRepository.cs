using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;

namespace EventiWebApp.Repositories
{
    public class EventiRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public EventiRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }
        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            var db = _dbContext.Eventis;
            var list = _dbContext.Eventis.Select(x => EventiMapper.FromDatabase(x));
            return list;
        }
    }
}
