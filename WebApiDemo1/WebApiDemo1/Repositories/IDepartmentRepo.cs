using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo1.Models;

namespace WebApiDemo1.Repositories
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartmentById(int id);
        public IEnumerable<Department> GetDepartmentByLocation(string loc);
        public string AddDepartment(Department department);
        public string UpdateDepartment(Department department);
        public string Deletedepartment(int id);
    }
}
