using TPFinal.Domain;

namespace TPFinal.DAL.EntityFramework
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private ManagerPrestamosDbContext ManagerPrestamosDbContext;
        public RepositorioUsuario(ManagerPrestamosDbContext pContext) 
        {
            ManagerPrestamosDbContext = pContext;
        }

        public void Agregar(UsuarioSimple pEntidad)
        {
            ManagerPrestamosDbContext.SaveChanges(pEntidad);
        }

        public void Eliminar(UsuarioSimple pEntidad)
        {
            throw new System.NotImplementedException();
        }

        public UsuarioSimple Get(int pId)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<UsuarioSimple> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public RepositorioUsuario getRepositorioUsuario(ManagerPrestamosDbContext pContext)
        {
            throw new System.NotImplementedException();
        }

        void IRepositorio<UsuarioSimple>.Agregar(UsuarioSimple pEntidad)
        {
            throw new System.NotImplementedException();
        }

        void IRepositorio<UsuarioSimple>.Eliminar(UsuarioSimple pEntidad)
        {
            throw new System.NotImplementedException();
        }

        UsuarioSimple IRepositorio<UsuarioSimple>.Get(int pId)
        {
            throw new System.NotImplementedException();
        }

        System.Collections.Generic.IEnumerable<UsuarioSimple> IRepositorio<UsuarioSimple>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}