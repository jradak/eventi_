using System;
using System.Collections.Generic;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class Mjestum
    {
        public Mjestum()
        {
            Eventis = new HashSet<Eventi>();
        }

        public int IdMjesto { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Eventi> Eventis { get; set; }
    }
}
