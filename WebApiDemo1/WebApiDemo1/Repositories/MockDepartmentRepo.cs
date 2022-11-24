using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo1.Models;
using WebApiDemo1.Context;

namespace WebApiDemo1.Repositories
{
    public class MockDepartmentRepo : IDepartmentRepo
    {
        public DepartmentEmployeeContext context = new DepartmentEmployeeContext();
       
        string IDepartmentRepo.AddDepartment(Department department)
        {
            string result=department.Name="Department Added successfully";
            context.Departments.Add(department);
            context.SaveChanges();
            return result;
        }

        string IDepartmentRepo.Deletedepartment(int id)
        {
            string result;
            Department dept = context.Departments.FirstOrDefault(d => d.Id == id);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                result = id + "from department is deleted";
            }
            else
            {
                result = "The id in department doesn't exist";
            }
            return result;
        }

        IEnumerable<Department> IDepartmentRepo.GetAllDepartments()
        {
            List<Department> departments = context.Departments.ToList();
            return departments;
        }

        Department GetDepartmentById(int id)
        {
            Department dept = context.Departments.FirstOrDefault(d => d.Id == id);
            return dept;
        }

        Department IDepartmentRepo.GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> GetDepartmentByLocation(string loc)
        {
            var dept = context.Departments.Where(d => d.Location == loc).ToList();
            return dept;
        }

        IEnumerable<Department> IDepartmentRepo.GetDepartmentByLocation(string loc)
        {
            throw new NotImplementedException();
        }

        string IDepartmentRepo.UpdateDepartment(Department department)
        {
            string result;
            Department dept = context.Departments.FirstOrDefault(d => d.Id == department.Id);
            if (dept != null)
            {
                dept = department;
                context.SaveChanges();
                result = department.Id + "is updated";
            }
            else
            {
                result = "Department doesn't exist";
            }
            return result;
        }
    }
}
