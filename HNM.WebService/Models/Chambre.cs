using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Chambre
    {
        public Chambre()
        {
            this.Nuits = new List<Nuit>();
            this.ServiceProposes = new List<ServicePropose>();
        }

        public int IdChambre { get; set; }
        public int IdProprietaire { get; set; }
        public int IdAdresse { get; set; }
        public string LibelleChambre { get; set; }
        public string DescriptionChambre { get; set; }
        public string Photo { get; set; }
        public virtual Adresse Adresse { get; set; }
        public virtual ICollection<Nuit> Nuits { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<ServicePropose> ServiceProposes { get; set; }
    }
}
