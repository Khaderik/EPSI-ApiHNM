using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Nuit
    {
        public Nuit()
        {
            this.Reservations = new List<Reservation>();
        }

        public int IdNuit { get; set; }
        public int IdChambre { get; set; }
        public System.DateTime DateNuit { get; set; }
        public byte[] DispoVisite { get; set; }
        public virtual Chambre Chambre { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
