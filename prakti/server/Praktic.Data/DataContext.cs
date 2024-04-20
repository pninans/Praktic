using Microsoft.EntityFrameworkCore;
using Praktic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
       // public DbSet<Role> roles { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=works_db");
        }


    }
}
