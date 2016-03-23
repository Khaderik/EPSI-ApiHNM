using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class AdresseMap : EntityTypeConfiguration<Adresse>
    {
        public AdresseMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAdresse);

            // Properties
            this.Property(t => t.IdAdresse)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NomVoie)
                .HasMaxLength(100);

            this.Property(t => t.Complement)
                .HasMaxLength(100);

            this.Property(t => t.Ville)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pays)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Adresse");
            this.Property(t => t.IdAdresse).HasColumnName("IdAdresse");
            this.Property(t => t.NumeroVoie).HasColumnName("NumeroVoie");
            this.Property(t => t.NomVoie).HasColumnName("NomVoie");
            this.Property(t => t.Complement).HasColumnName("Complement");
            this.Property(t => t.CodePostal).HasColumnName("CodePostal");
            this.Property(t => t.Ville).HasColumnName("Ville");
            this.Property(t => t.Pays).HasColumnName("Pays");
        }
    }
}
