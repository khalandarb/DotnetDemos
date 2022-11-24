using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAssignment.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should have min-5 max-20 characters")]
        public string Name { get; set; }

        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$")]

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword does not match")]
        public string ConfirmPassword { get; set; }
    }
}