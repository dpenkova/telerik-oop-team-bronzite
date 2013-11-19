using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Product
    {
        public string Name { get; set; }
        public double ProductWeight { get; set; }
        public string Kind { get; set; }

        public Product(string productName, double productWeight)
        {
            this.Name = productName;
            this.ProductWeight = productWeight;
        }

        public Product()
        {

        }
    }
}
