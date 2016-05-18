using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class NuitMap : EntityTypeConfiguration<Nuit>
    {
        public NuitMap()
        {
            // Primary Key
            this.HasKey(t => t.IdNuit);

            // Properties
            this.Property(t => t.IdNuit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DispoVisite)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Nuit");
            this.Property(t => t.IdNuit).HasColumnName("IdNuit");
            this.Property(t => t.IdChambre).HasColumnName("IdChambre");
            this.Property(t => t.IdReservation).HasColumnName("IdReservation");
            this.Property(t => t.DateNuit).HasColumnName("DateNuit");
            this.Property(t => t.DispoVisite).HasColumnName("DispoVisite");

            // Relationships
            this.HasMany(t => t.ServiceChoisis)
                .WithMany(t => t.Nuits)
                .Map(m =>
                    {
                        m.ToTable("ServiceChoisi");
                        m.MapLeftKey("IdNuit");
                        m.MapRightKey("IdServicePropose");
                    });

            this.HasRequired(t => t.Chambre)
                .WithMany(t => t.Nuits)
                .HasForeignKey(d => d.IdChambre);
            this.HasOptional(t => t.Reservation)
                .WithMany(t => t.Nuits)
                .HasForeignKey(d => d.IdReservation);

        }
    }
}
