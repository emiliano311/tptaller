using System;

namespace TPFinal.DAL.EntityFramework
{
    class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly ManagerPrestamosDbContext iDbContext;
        public UnidadDeTrabajo(ManagerPrestamosDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iDbContext = pContext;
            this.RepositorioUsuario = new RepositorioUsuario(this.iDbContext);
            this.RepositorioPrestamos = new RepositorioPrestamos(this.iDbContext);
        }
        public IRepositorioPrestamos RepositorioPrestamos
        {
            get; private set;
        }
        public IRepositorioUsuario RepositorioUsuario
        {
            get; private set;
        }
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
