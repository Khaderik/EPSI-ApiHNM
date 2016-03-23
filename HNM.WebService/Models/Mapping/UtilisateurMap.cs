using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HNM.WebService.Models.Mapping
{
    public class UtilisateurMap : EntityTypeConfiguration<Utilisateur>
    {
        public UtilisateurMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUtilisateur);

            // Properties
            this.Property(t => t.IdUtilisateur)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pseudo)
                .HasMaxLength(20);

            this.Property(t => t.Nom)
                .HasMaxLength(50);

            this.Property(t => t.Prenom)
                .HasMaxLength(50);

            this.Property(t => t.AdresseMail)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Utilisateur");
            this.Property(t => t.IdUtilisateur).HasColumnName("IdUtilisateur");
            this.Property(t => t.IdAdresse).HasColumnName("IdAdresse");
            this.Property(t => t.Pseudo).HasColumnName("Pseudo");
            this.Property(t => t.Nom).HasColumnName("Nom");
            this.Property(t => t.Prenom).HasColumnName("Prenom");
            this.Property(t => t.AdresseMail).HasColumnName("AdresseMail");
            this.Property(t => t.DateNaissance).HasColumnName("DateNaissance");

            // Relationships
            this.HasRequired(t => t.Adresse)
                .WithMany(t => t.Utilisateurs)
                .HasForeignKey(d => d.IdAdresse);

        }
    }
}
