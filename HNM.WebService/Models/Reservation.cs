using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            this.Nuits = new List<Nuit>();
        }

        public int IdReservation { get; set; }
        [JsonIgnore]
        public int IdUtilisateur { get; set; }
        public Nullable<System.DateTime> DateReservation { get; set; }
        public virtual ICollection<Nuit> Nuits { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
