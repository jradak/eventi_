using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;

namespace EventiWebApp.Mappers
{
    public class EventiMapper
    {
        public static Eventi FromDatabase(DbModels.Eventi e)
        {
            return new Models.Eventi(e.IdEvent, e.Naziv, e.Vrijeme, e.Mjesto, e.Adresa, e.Cijena, e.VrstaEventa, e.Organizator, e.OgraniceniPosjetitelji);
        }
        public static DbModels.Eventi ToDatabase(Eventi e)
        {
            DbModels.Eventi x = new DbModels.Eventi
            {
                Naziv = e.Naziv,
                Vrijeme = e.Vrijeme,
                Mjesto = e.Mjesto,
                Adresa = e.Adresa,
                Cijena = e.Cijena,
                VrstaEventa = e.VrstaEventa,
                Organizator = e.Organizator,
                OgraniceniPosjetitelji = e.OgraniceniPosjetitelji
            };
            if (e.IdEvent != null)
            {
                x.IdEvent = (int)e.IdEvent;
            }
            return x;

        }
    }
}
