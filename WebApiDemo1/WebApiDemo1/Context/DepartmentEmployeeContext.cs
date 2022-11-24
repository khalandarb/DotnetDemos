using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiDemo1.Models;

namespace WebApiDemo1.Context
{
    public class DepartmentEmployeeContext:DbContext
    {
        public DepartmentEmployeeContext() { }
        public DepartmentEmployeeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
