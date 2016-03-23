using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.IdService);

            // Properties
            this.Property(t => t.IdService)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LibelleService)
                .HasMaxLength(100);

            this.Property(t => t.DescriptionService)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Service");
            this.Property(t => t.IdService).HasColumnName("IdService");
            this.Property(t => t.LibelleService).HasColumnName("LibelleService");
            this.Property(t => t.DescriptionService).HasColumnName("DescriptionService");
        }
    }
}
