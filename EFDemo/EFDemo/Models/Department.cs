using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Display(Name ="Department Name")]
        [Required(ErrorMessage ="Department name is required")]
        public string name { get; set; }
        public string location { get; set; }
    }
}