using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class ServicePropose
    {
        public ServicePropose()
        {
            this.ServiceChoisis = new List<ServiceChoisi>();
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
        public virtual ICollection<ServiceChoisi> ServiceChoisis { get; set; }
    }
}
