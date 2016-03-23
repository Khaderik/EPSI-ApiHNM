using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class ReservationMap : EntityTypeConfiguration<Reservation>
    {
        public ReservationMap()
        {
            // Primary Key
            this.HasKey(t => t.IdReservation);

            // Properties
            this.Property(t => t.IdReservation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Reservation");
            this.Property(t => t.IdReservation).HasColumnName("IdReservation");
            this.Property(t => t.IdUtilisateur).HasColumnName("IdUtilisateur");
            this.Property(t => t.IdNuit).HasColumnName("IdNuit");
            this.Property(t => t.DateReservation).HasColumnName("DateReservation");

            // Relationships
            this.HasRequired(t => t.Nuit)
                .WithMany(t => t.Reservations)
                .HasForeignKey(d => d.IdNuit);
            this.HasRequired(t => t.Utilisateur)
                .WithMany(t => t.Reservations)
                .HasForeignKey(d => d.IdUtilisateur);

        }
    }
}
