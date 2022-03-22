using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TPFinal.DAL.EntityFramework
{
    public class Repositorio
    {
        abstract class Repositorio1<TEntidad, TDbContext> : IRepositorio<TEntidad>
        where TEntidad : class
        where TDbContext : DbContext
        {
            protected readonly TDbContext iDbContext;
            public Repositorio1(TDbContext pContext)
            {
                if (pContext == null)
                {
                    throw new ArgumentNullException(nameof(pContext));
                }
                this.iDbContext = pContext;
            }
            public void Agregar(TEntidad pEntidad)
            {
                if (pEntidad == null)
                {
                    throw new ArgumentNullException(nameof(pEntidad));
                }
                this.iDbContext.Set<TEntidad>().Add(pEntidad);
            }
            public TEntidad Get(int pId)
            {
                return this.iDbContext.Set<TEntidad>().Find(pId);
            }
            public IEnumerable<TEntidad> GetAll()
            {
                return this.iDbContext.Set<TEntidad>().ToList();
            }
            public void Eliminar(TEntidad pEntidad)
            {
                if (pEntidad == null)
                {
                    throw new ArgumentNullException(nameof(pEntidad));
                }
                this.iDbContext.Set<TEntidad>().Remove(pEntidad);
            }
        }
   }
}