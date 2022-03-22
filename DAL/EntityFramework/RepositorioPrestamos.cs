using TPFinal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TPFinal.DAL.EntityFramework
{
    public class RepositorioPrestamos: IRepositorioPrestamos
    {
        public RepositorioPrestamos(ManagerPrestamosDbContext pContext)
        {
        }

        public void Agregar(Prestamo pEntidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Prestamo pEntidad)
        {
            throw new NotImplementedException();
        }

        public Prestamo Get(int pId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prestamo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Prestamo GetPrestamo(UsuarioSimple pUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> GetPrestamosActivos()
        {
            throw new NotImplementedException();
        }
    }
}