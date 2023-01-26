using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;

namespace EventiWebApp.Mappers
{
    public class KorisnikEventiMapper
    {
        public static KorisnikEvent FromDatabase(DbModels.KorisnikEvent ke)
        {
            return new KorisnikEvent(ke.IdKorisnikEvent, ke.Event, ke.Korisnik, ke.Potvrdeno, ke.Recenzija);
        }
        public static DbModels.KorisnikEvent ToDatabase(KorisnikEvent ke)
        {
            DbModels.KorisnikEvent x = new DbModels.KorisnikEvent
            {
                Event = ke.Event,
                Korisnik = ke.Korisnik,
                Potvrdeno = ke.Potvrdeno,
                Recenzija = ke.Recenzija
            };
            if (ke.IdKorisnikEvent != null)
            {
                x.IdKorisnikEvent = (int)ke.IdKorisnikEvent;
            }
            return x;
        }
    }
}
