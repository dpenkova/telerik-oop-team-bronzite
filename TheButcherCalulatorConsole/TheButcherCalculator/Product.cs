﻿using System;
using System.Linq;

namespace TheButcherCalculator
{
    public class Product
    {
        public string Name { get; set; }
        public double ProductWeight { get; set; }

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
