using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email!")]
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Password doesn't match.")]

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
