using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetValue(int id);
        void Add(T make);
        void Update(T make);
        void Delete(int id);
    }
}
