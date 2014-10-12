using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IService<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
        void Save(int id, T o);
    }
}
