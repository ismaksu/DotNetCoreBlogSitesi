using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CodersPC\\SQLEXPRESS; Database=ApiDb_CoreBlog; Integrated Security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
