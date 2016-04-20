using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Nuit
    {
        public int IdNuit { get; set; }
        [JsonIgnore]
        public int IdChambre { get; set; }
        [JsonIgnore]
        public Nullable<int> IdReservation { get; set; }
        public System.DateTime DateNuit { get; set; }
        public byte[] DispoVisite { get; set; }
        public virtual Chambre Chambre { get; set; }
        [JsonIgnore]
        public virtual Reservation Reservation { get; set; }
    }
}
