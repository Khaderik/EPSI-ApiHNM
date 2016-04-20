using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Service
    {
        public Service()
        {
            this.ServiceProposes = new List<ServicePropose>();
        }

        public int IdService { get; set; }
        public string LibelleService { get; set; }
        public string DescriptionService { get; set; }
        [JsonIgnore]
        public virtual ICollection<ServicePropose> ServiceProposes { get; set; }
    }
}
