using System;
using System.Collections.Generic;

namespace HNM.WebService.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            this.Chambres = new List<Chambre>();
            this.Reservations = new List<Reservation>();
        }

        public int IdUtilisateur { get; set; }
        public int IdAdresse { get; set; }
        public string Pseudo { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public virtual Adresse Adresse { get; set; }
        public virtual ICollection<Chambre> Chambres { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
