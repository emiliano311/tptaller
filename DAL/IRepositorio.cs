using System.Collections.Generic;

namespace TPFinal.DAL
{
    interface IRepositorio<TEntidad> where TEntidad : class
    {
        void Agregar(TEntidad pEntidad);
        void Eliminar(TEntidad pEntidad);
        TEntidad Get(int pId);
        IEnumerable<TEntidad> GetAll();
    }
}