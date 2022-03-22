using TPFinal.DAL.EntityFramework.Mappings;
using TPFinal.Domain;
using System.Data.Entity;
using System;

namespace TPFinal.DAL.EntityFramework
{
    public class ManagerPrestamosDbContext : DbContext
    {
        public DbSet<UsuarioSimple> usuarios { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }

        //private IDbConnectionFactory dbContext;
      //  private readonly ApplicationDbContext _context;


        public ManagerPrestamosDbContext() : base("name=ManagerPrestamosContext")
        {
           
             Database.SetInitializer<ManagerPrestamosDbContext>(new DatabaseInitializationStrategy());

        }

        internal void SaveChanges(UsuarioSimple pEntidad)
        {
            //  usuarios.Add(pEntidad);
           // this.SaveChanges(pEntidad);
          
        }


        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.Add(new UsuarioMap());
            pModelBuilder.Configurations.Add(new PrestamoMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}