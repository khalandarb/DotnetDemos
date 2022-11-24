using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingAssignment
{
    public class Category
    {
        public int id { get; set; }
        public string category { get; set; }

        public Category()
        {

        }
        Category(string cat)
        {
            this.category = cat;
        }

        public string getCat()
        {
            return this.category;
        }
    }
}
