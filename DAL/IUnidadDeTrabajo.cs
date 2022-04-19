using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace TPFinal.DAL
{
    interface IUnidadDeTrabajo<TContext> : IDisposable where TContext : DbContext, new()
    {
        Task<int> SaveAsync();
    }
}