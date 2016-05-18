using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class ServicePropose
    {
        public ServicePropose()
        {
            this.Nuits = new List<Nuit>();
        }

        public int IdServicePropose { get; set; }
        [JsonIgnore]
        public int IdChambre { get; set; }
        [JsonIgnore]
        public int IdService { get; set; }
        public Nullable<double> Tarif { get; set; }
        [JsonIgnore]
        public virtual Chambre Chambre { get; set; }
        public virtual Service Service { get; set; }
        [JsonIgnore]
        public virtual ICollection<Nuit> Nuits { get; set; }
    }
}
