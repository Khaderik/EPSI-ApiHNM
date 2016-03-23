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
            //sdfsdfdsfdsfsd
        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Nuit> Nuits { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceChoisi> ServiceChoisis { get; set; }
        public DbSet<ServicePropose> ServiceProposes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

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
        petit test de modif synchro
    }
}
