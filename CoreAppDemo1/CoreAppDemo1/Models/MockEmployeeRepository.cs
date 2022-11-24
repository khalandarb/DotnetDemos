using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppDemo1.Models
{
    public class MockEmployeeRepository : EmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){id=1,name="harry potter",email="harry@gmail.com",department="IT"},
                new Employee(){id=2,name="Ronald Weasley",email="ronald@gmail.com",department="CS"},
                new Employee(){id=3,name="Draco Malfoy",email="draco@gmail.com",department="Sales"}
            };
        }
        public Employee GetEmployee(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(emp => emp.id == id);
            return employee;
        }
    }
}
