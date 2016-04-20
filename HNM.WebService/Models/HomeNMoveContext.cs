using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using HNM.WebService.Models.Mapping;

namespace HNM.WebService.Models
{
    public partial class HomeNMoveContext : DbContext
    {
        static HomeNMoveContext()
        {
            Database.SetInitializer<HomeNMoveContext>(null);
        }

        public HomeNMoveContext()
            : base("Name=HomeNMoveContext")
        {
        }

        public IDbSet<Adresse> Adresses { get; set; }
        public IDbSet<Chambre> Chambres { get; set; }
        public IDbSet<Nuit> Nuits { get; set; }
        public IDbSet<Reservation> Reservations { get; set; }
        public IDbSet<Service> Services { get; set; }
        public IDbSet<ServiceChoisi> ServiceChoisis { get; set; }
        public IDbSet<ServicePropose> ServiceProposes { get; set; }
        public IDbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdresseMap());
            modelBuilder.Configurations.Add(new ChambreMap());
            modelBuilder.Configurations.Add(new NuitMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new ServiceMap());
            modelBuilder.Configurations.Add(new ServiceChoisiMap());
            modelBuilder.Configurations.Add(new ServiceProposeMap());
            modelBuilder.Configurations.Add(new UtilisateurMap());
        }
    }
}
