using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ValidationDemo.CustomDOB;

namespace ValidationDemo.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Name should have Min 4 & Max 10 characters")]
        public string name { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string email { get; set; }
        public long mobile { get; set; }
        [Range(21, 60, ErrorMessage = "Age should be between 21-60")]
        public int age { get; set; }
        [Display(Name ="Date of Birth")]
        [CustomDateOfBirth(ErrorMessage = "DOB should be less than or equal to current Date")]
        public DateTime DOB { get; set; }
        public string address { get; set; }
        [DataType(DataType.PostalCode)]
        public int pincode { get; set; }
        public string username { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password's doesn't match")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Url)]
        public string url { get; set; }

    }
}
