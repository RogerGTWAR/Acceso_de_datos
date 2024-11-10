using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Customer
    {
        internal readonly int CustomerId;

        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]

        public string LastName { get; set; }
        public ICollection<CreditRisk> CreditRisks { get; set; }

    }
}
