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
        public int IdChambre { get; set; }
        public int IdService { get; set; }
        public Nullable<double> Tarif { get; set; }
        public virtual Chambre Chambre { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<ServiceChoisi> ServiceChoisis { get; set; }
    }
}
