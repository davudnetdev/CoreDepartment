using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DKQQPCF\\SQLEXPRESS;database=CorePersonal;integrated security=true;");
        }
        public DbSet<Department>Departments { get; set; }
        public DbSet<Personal>Personals{ get; set; }
    }
}
