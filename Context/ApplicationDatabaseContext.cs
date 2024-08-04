using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Model;

namespace Task_EF.Context
{
    internal class ApplicationDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server = .; Database = Task_EF ; Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
