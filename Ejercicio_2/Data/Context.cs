using Ejercicio_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Data
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