using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Data
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CreditRisk> CreditRisks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
