using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeBased_Demo1.Models;

namespace EF_CodeBased_Demo1.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
