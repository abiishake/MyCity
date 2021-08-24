using Microsoft.EntityFrameworkCore;
using MyCTAPI.Core.Interface.UnitOfWork;
using MyCTAPI.Core.Repository;
using DataAccessLayer.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CTDbContext _CTDbContext;
        private bool _disposed = false;

        public ICTUserRepository CTUsers => throw new NotImplementedException();

        public DbSet<TModel> Collection<TModel>() where TModel : class
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _CTDbContext.Database.GetDbConnection().Close();
                    _CTDbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //
        }

        public void InitCTDb()
        {
            if (_CTDbContext == null)
            {
                _CTDbContext = new CTDbContext();
            }
        }

        public int SaveCT()
        {
            this.InitCTDb();
            try
            {
                return _CTDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            this.InitCTDb();
            return _CTDbContext.Set<TEntity>();
        }


    }
}
