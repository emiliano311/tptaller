using TPFinal.Domain;
using System.Data.Entity.ModelConfiguration;

namespace TPFinal.DAL.EntityFramework.Mappings
{
    public class PrestamoMap : EntityTypeConfiguration<Prestamo>
    {
        public PrestamoMap()
        {
            this.ToTable("Prestamo");
            this.HasKey(pPrestamo => pPrestamo.IdPrestamo)
                .Property(pPrestamo => pPrestamo.IdPrestamo)
                .HasColumnName("Id_Prestamo")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(pPrestamo => pPrestamo.FechaInicio)
                .IsRequired()                
                .HasColumnName("Fecha_Inicio");
            this.Property(pPrestamo => pPrestamo.FechaFin)
                .IsRequired()                
                .HasColumnName("Fecha_Fin");
           /* this.HasMany(pPrestamo => pPrestamo.FechaVencimiento)
                .IsRequired()                
                .HasColumnName("Fecha_Fin");*/
        }
    }
}