using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;

namespace EventiWebApp.Mappers
{
    public class VrsteEventaMapper
    {
        public static VrsteEventa FromDatabase(DbModels.VrsteEventum v)
        {
            return new VrsteEventa(v.IdVrsta, v.Naziv);
        }
        public static DbModels.VrsteEventum ToDatabase(VrsteEventa v)
        {
            DbModels.VrsteEventum x = new DbModels.VrsteEventum
            {
                Naziv = v.Naziv
            };
            if (v.IdVrsta != null)
            {
                x.IdVrsta = (int)v.IdVrsta;
            }
            return x;
        }
    }
}
