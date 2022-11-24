using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingAssignment
{
    class Product
    {
        public int id { get; set; }
        public Category category;
        public string product { get; set; }
        public double price { get; set; }
    }
}
