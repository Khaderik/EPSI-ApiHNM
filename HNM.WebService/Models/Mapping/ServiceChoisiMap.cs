using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class ServiceChoisiMap : EntityTypeConfiguration<ServiceChoisi>
    {
        public ServiceChoisiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdNuit, t.IdServicePropose });

            // Properties
            this.Property(t => t.IdNuit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdServicePropose)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ServiceChoisi");
            this.Property(t => t.IdNuit).HasColumnName("IdNuit");
            this.Property(t => t.IdServicePropose).HasColumnName("IdServicePropose");

            // Relationships
            this.HasRequired(t => t.ServicePropose)
                .WithMany(t => t.ServiceChoisis)
                .HasForeignKey(d => d.IdServicePropose);

        }
    }
}
