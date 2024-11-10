using Entity_Framework.Data;
using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class CreditRisksRepository : Repository<CreditRisk>
    {
        public List<CreditRisk> GetByName(string riesgo)
        {
            using (var context = new Context())
            {
                return context.CreditRisks.Where(credit => credit.FirstName.Contains(riesgo)).ToList();
            }
        }

        public List<CreditRisk> GetByLastName(string tipo)
        {
            using (var context = new Context())
            {
                return context.CreditRisks.Where(credit => credit.LastName.Contains(tipo)).ToList();
            }
        }

        public List<CreditRisk> GetByNameandLastName(string riesgo, string tipo)
        {
            using (var context = new Context())
            {
                return context.CreditRisks.Where(credit => credit.FirstName.Contains(riesgo) && credit.LastName.Contains(tipo)).ToList();
            }
        }
    }
}
