using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;

namespace EventiWebApp.Mappers
{
    public class MjestaMapper
    {
        public static Mjesta FromDatabase(DbModels.Mjestum m)
        {
            return new Mjesta(m.IdMjesto, m.Naziv);
        }
        public static DbModels.Mjestum ToDatabase(Mjesta m)
        {
            DbModels.Mjestum x = new DbModels.Mjestum
            {
                Naziv = m.Naziv
            };
            if (m.IdMjesto != null)
            {
                x.IdMjesto = (int)m.IdMjesto;
            }
            return x;
        }
    }
}
