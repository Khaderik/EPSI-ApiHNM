using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class ChambreMap : EntityTypeConfiguration<Chambre>
    {
        public ChambreMap()
        {
            // Primary Key
            this.HasKey(t => t.IdChambre);

            // Properties
            this.Property(t => t.IdChambre)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LibelleChambre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DescriptionChambre)
                .HasMaxLength(1000);

            this.Property(t => t.Photo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Chambre");
            this.Property(t => t.IdChambre).HasColumnName("IdChambre");
            this.Property(t => t.IdProprietaire).HasColumnName("IdProprietaire");
            this.Property(t => t.IdAdresse).HasColumnName("IdAdresse");
            this.Property(t => t.LibelleChambre).HasColumnName("LibelleChambre");
            this.Property(t => t.DescriptionChambre).HasColumnName("DescriptionChambre");
            this.Property(t => t.Photo).HasColumnName("Photo");

            // Relationships
            this.HasRequired(t => t.Adresse)
                .WithMany(t => t.Chambres)
                .HasForeignKey(d => d.IdAdresse);
            this.HasRequired(t => t.Utilisateur)
                .WithMany(t => t.Chambres)
                .HasForeignKey(d => d.IdProprietaire);

        }
    }
}
