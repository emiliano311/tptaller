using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using PFinal.DAL.EntityFramework;
using EntityFramework.PrimaryKey;

namespace TPFinal.DAL.EntityFramework
{
    public class Repositorio<TContext, TEntity> : IRepositorio<TContext, TEntity>
          where TEntity : class
          where TContext : DbContext
    {
        internal TContext Context;
        internal DbSet<TEntity> DbSet;

        public Repositorio(TContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> GetAll() => DbSet;

        public virtual async Task<TEntity> GetByID(object id) => await DbSet.FindAsync(id);

        public virtual async Task Insert(TEntity entity)
        {
            await Task.Run(delegate ()
            {
                DbSet.Add(entity);
            });

            var entry = await GetEntry(entity);
            entry.State = EntityState.Added;
        }

        public virtual async Task Update(TEntity entity)
        {
            var entry = await GetEntry(entity);

            await Task.Run(delegate ()
            {
                entry.CurrentValues.SetValues(entity);
                entry.State = EntityState.Modified;
            });
        }

        public virtual async Task Upsert(TEntity entity)
        {
            if (await GetEntity(entity) != null)
            {
                await Update(entity);
            }

            else
            {
                await Insert(entity);
            }
        }

        public virtual void Delete(object id) => Delete(GetByID(id));

        public virtual async Task Delete(TEntity entity)
        {
            var entry = await GetEntry(entity);

            await Task.Run(delegate ()
            {
                if (entry.State == EntityState.Detached)
                {
                    DbSet.Attach(entity);
                }
                DbSet.Remove(entity);
            });
        }


        public object GetPrimaryKey(TEntity entity) => Context.GetPrimaryKey(entity).Values.First();

        public async Task<TEntity> GetEntity(TEntity entity) => await GetByID(GetPrimaryKey(entity));

        protected async Task<DbEntityEntry> GetEntry(TEntity entity) => Context.Entry(await GetEntity(entity));
    }
}