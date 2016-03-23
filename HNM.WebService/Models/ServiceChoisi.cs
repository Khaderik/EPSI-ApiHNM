using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class ServiceChoisi
    {
        public int IdNuit { get; set; }
        public int IdServicePropose { get; set; }
        public virtual ServicePropose ServicePropose { get; set; }
    }
}
