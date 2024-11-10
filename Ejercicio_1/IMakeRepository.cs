using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public interface IMakeRepository
    {
        List<Make> GetAll();
        Make GetById(int id);
        void Insert(Make make);
        void Update(Make make);
        void Delete(int id);
    }
}
