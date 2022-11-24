using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFDemo.Models
{
    public class DepartmentContext:DbContext
    {
        public DepartmentContext():base("myconnection")
        {

        }

        //table

        public DbSet<Department> Departments { get; set; }
    }
}