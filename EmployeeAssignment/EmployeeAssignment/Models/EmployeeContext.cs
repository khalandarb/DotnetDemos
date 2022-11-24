using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EmployeeAssignment.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("myconnection")
        {

        }
        //create table in db
        public DbSet<Employee> Employees { get; set; }
    }
}