using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Repositories;

namespace EventiWebApp.Services
{
    public class EventiServices
    {
        public EventiRepository _eventiRepository;
        
        public EventiServices(EventiRepository eventiRepostiory)
        {
            _eventiRepository = eventiRepostiory;
        }

        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            return _eventiRepository.GetAllEventi();
        }
    }
}
