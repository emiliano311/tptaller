using TPFinal.DAL.EntityFramework;
using TPFinal.Domain;

namespace TPFinal.DAL
{
    interface IRepositorioUsuario : IRepositorio<UsuarioSimple>
    {
         RepositorioUsuario getRepositorioUsuario (ManagerPrestamosDbContext pContext);
    }
}