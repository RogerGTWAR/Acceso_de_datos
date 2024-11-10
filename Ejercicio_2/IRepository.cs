using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetByID(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        //List<TEntity> Buscar(Func<TEntity, bool> predicate);
    }
}
