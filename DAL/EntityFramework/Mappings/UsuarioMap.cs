using System;
using TPFinal.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPFinal.DAL.EntityFramework.Mappings
{

    public class UsuarioMap : EntityTypeConfiguration<UsuarioSimple>
    {
        public UsuarioMap()
        {
            this.ToTable("Usuario_Simple");
            this.HasKey(pUsuario => pUsuario.NumeroUsuario)
                .Property(pUsuario => pUsuario.NumeroUsuario)
                .HasColumnName("Numero_Usuario")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(pUsuario => pUsuario.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(70); 
            this.Property(pUsuario => pUsuario.Direccion)
                .HasColumnName("Direccion")
                .IsRequired()
                .HasMaxLength(100);
            this.Property(pUsuario => pUsuario.Telefono)
                .HasColumnName("Telefono")
                .IsRequired();
            //.HasMaxLength(32);
            this.Property(pUsuario => pUsuario.Documento)
                .HasColumnName("Documento")
                .IsRequired();
                //.HasMaxLength(15); // por si es Cuil o Cuit
            this.Property(pUsuario => pUsuario.Puntaje)
                .HasColumnName("Puntaje")
                .IsRequired();
            this.Property(pUsuario => pUsuario.Mail)
                .HasColumnName("Mail")
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}