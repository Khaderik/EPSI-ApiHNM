using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class ServiceProposeMap : EntityTypeConfiguration<ServicePropose>
    {
        public ServiceProposeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdServicePropose);

            // Properties
            this.Property(t => t.IdServicePropose)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ServicePropose");
            this.Property(t => t.IdServicePropose).HasColumnName("IdServicePropose");
            this.Property(t => t.IdChambre).HasColumnName("IdChambre");
            this.Property(t => t.IdService).HasColumnName("IdService");
            this.Property(t => t.Tarif).HasColumnName("Tarif");

            // Relationships
            this.HasRequired(t => t.Chambre)
                .WithMany(t => t.ServiceProposes)
                .HasForeignKey(d => d.IdChambre);
            this.HasRequired(t => t.Service)
                .WithMany(t => t.ServiceProposes)
                .HasForeignKey(d => d.IdService);

        }
    }
}
