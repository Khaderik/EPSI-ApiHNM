using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Reservation
    {
        public int IdReservation { get; set; }
        public int IdUtilisateur { get; set; }
        public int IdNuit { get; set; }
        public Nullable<System.DateTime> DateReservation { get; set; }
        public virtual Nuit Nuit { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
