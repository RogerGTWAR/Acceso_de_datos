using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetValue(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
