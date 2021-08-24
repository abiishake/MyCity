using Microsoft.EntityFrameworkCore;
using MyCTAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCTAPI.Core.Interface.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void InitCTDb();

        ICTUserRepository CTUsers { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet<TModel> Collection<TModel>() where TModel : class;
        int SaveCT();
    }
}
