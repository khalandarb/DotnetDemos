using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeBased_Demo1.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string company { get; set; }
        public string designation { get; set; }
        public float salary { get; set; }
    }
}
