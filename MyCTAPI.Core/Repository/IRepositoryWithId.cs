using MyCTAPI.Core.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCTAPI.Core.Repository
{
    public interface IRepositoryWithId<T> : IRepository<T> where T: class, IEntity
    {
        T GetById(int id);
        void RemoveById(int id);
    }
}
