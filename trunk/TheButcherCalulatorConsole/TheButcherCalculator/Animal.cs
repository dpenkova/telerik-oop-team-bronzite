using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public abstract class Animal
    {
        //just a test
        //fields
        private string kind;
        private double totalWeight;
        //properties
        
        public string Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                this.kind = value;
            }
        }

        public double TotalWeight
        {
            get
            {
                return this.totalWeight;
            }
            set
            {
                this.totalWeight = value;
            }
        }
        //constructors
        protected Animal(string kind, double totalWeight)
        {
            this.Kind = kind;
            this.TotalWeight = totalWeight;
        }
    }
}
