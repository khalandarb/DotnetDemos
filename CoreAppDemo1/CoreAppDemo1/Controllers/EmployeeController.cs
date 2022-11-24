using CoreAppDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public String Index()
        {
            var emp = _employeeRepository.GetEmployee(1);
            string empDetails=emp.id+"\t"+emp.name+"\t"+emp.email+"\t" + emp.department;
            return empDetails;
        }
    }
}
