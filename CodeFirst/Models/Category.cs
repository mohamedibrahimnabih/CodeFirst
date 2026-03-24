using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        // Navigation Prop.
    }
}
