using PFinal.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.EntityFramework;

namespace TPFinal.DAL
{
    public abstract class GenericUnitOfWork<TContext> : IUnidadDeTrabajo<TContext> where TContext : DbContext, new()
    {
        public bool Disposed = false;
        protected readonly TContext Context;

        public GenericUnitOfWork()
        {
            this.Context = new TContext();
        }

        public IRepositorio<TContext, TEntity> GetRepository<TEntity>() where TEntity : class => new Repositorio<TContext, TEntity>(Context);

        public async Task<int> SaveAsync() => await this.Context.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    this.Context.Dispose();
                }
            }

            this.Disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

