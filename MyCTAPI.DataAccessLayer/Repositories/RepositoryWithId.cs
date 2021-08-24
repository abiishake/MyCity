using MyCTAPI.Core.Interface.DependencyInjector;
using MyCTAPI.Core.Interface.Model;
using MyCTAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RepositoryWithId<T> : Repository<T>, IRepositoryWithId<T> where T : class, IEntity
    {
        public RepositoryWithId(IServiceLocator serviceLocator)
           : base(serviceLocator)
        {
        }
       

        public T GetById(int id)
        {
            T entity = this._records.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void RemoveById(int id)
        {
            this._records.Remove(GetById(id));
        }

    }
}
