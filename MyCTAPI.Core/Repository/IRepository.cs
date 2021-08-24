using MyCTAPI.Core.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCTAPI.Core.Repository
{
    public interface IRepository<T> : IDisposable where T : class, IEntity
    {
        void Init();
        IQueryable<T> Records();
        void Add(T entity);
        List<T> GetAll();
    }
}
