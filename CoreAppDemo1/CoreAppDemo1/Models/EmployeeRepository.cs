using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppDemo1.Models
{
    public interface EmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
