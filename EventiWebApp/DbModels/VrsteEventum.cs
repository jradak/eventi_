using System;
using System.Collections.Generic;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class VrsteEventum
    {
        public VrsteEventum()
        {
            Eventis = new HashSet<Eventi>();
        }

        public int IdVrsta { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Eventi> Eventis { get; set; }
    }
}
