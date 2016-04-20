using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            this.Chambres = new List<Chambre>();
            this.Utilisateurs = new List<Utilisateur>();
        }

        public int IdAdresse { get; set; }
        public Nullable<int> NumeroVoie { get; set; }
        public string NomVoie { get; set; }
        public string Complement { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        [JsonIgnore]
        public virtual ICollection<Chambre> Chambres { get; set; }
        [JsonIgnore]
        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
