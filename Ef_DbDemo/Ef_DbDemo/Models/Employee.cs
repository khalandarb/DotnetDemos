using System;
using System.Collections.Generic;

#nullable disable

namespace Ef_DbDemo.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designatiion { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
