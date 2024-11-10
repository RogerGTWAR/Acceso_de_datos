using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public interface IRepository
    {
        List<Inventario> GetAll();
        Inventario GetById(int id);
        void Insert(Inventario inventario);
        void Update(Inventario inventario);
        void Delete(int id);
    }
}
