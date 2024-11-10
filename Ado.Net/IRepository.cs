using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByName(string name, string color);
        T GetById(int id);
        void Add(T ado);
        void Update(T ado);
        void Delete(int id);
    }
}
