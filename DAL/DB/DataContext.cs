using TPFinal.Domain;
using System.Data.Entity;
using System;

namespace TPFinal.DAL.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<UsuarioSimple> usuarios { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }
        public DbSet<Ejemplar> ejemplar { get; set; }

        public DataContext() : base("name=ManagerPrestamosContext")
        { }

    }
}