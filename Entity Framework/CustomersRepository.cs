using Entity_Framework.Data;
using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class CustomersRepository : Repository<Customer>
    {
        public List<Customer> GetByName(string firstName)
        {
            using (var context = new Context())
            {
                return context.Customers.Where(customer => customer.FirstName.Contains(firstName)).ToList();
            }
        }

        public List<Customer> GetByLastName(string lastName)
        {
            using (var context = new Context())
            {
                return context.Customers.Where(customer => customer.LastName.Contains(lastName)).ToList();
            }
        }

        public List<Customer> GetByNameandLastName(string firstName, string lastName)
        {
            using (var context = new Context())
            {
                return context.Customers.Where(customer => customer.FirstName.Contains(firstName) && customer.LastName.Contains(lastName)).ToList();
            }
        }

    }
}
