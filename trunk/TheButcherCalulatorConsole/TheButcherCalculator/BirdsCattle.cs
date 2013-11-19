using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public abstract class BirdsCattle : Animal, ISeparatable
    {
        // constants for percentage
        private const double MeatPercentage = 0.3;
        private const double LegsPercentage = 0.3;
        private const double WingsPercentage = 0.1;
        private const double OffalPercentage = 0.1;
        private const double WastePercentage = 0.1;

        protected double MeatWeight
        {
            get { return this.TotalWeight * MeatPercentage; } 
        }
        protected double LegsWeight
        {
            get { return this.TotalWeight * LegsPercentage; }
        }
        protected double WingsWeight
        {
            get { return this.TotalWeight * WingsPercentage; }
        }
        protected double WasteWeight
        {
            get { return this.TotalWeight * WastePercentage; }
        }
        protected double OffalWeight
        {
            get { return this.TotalWeight * OffalPercentage; }
        }

        //constructor
        protected BirdsCattle(string kind, int totalWeight)
            : base(kind, totalWeight)
        {
        }

        public abstract List<Product> ProduceGoods();
        public abstract List<Product> ProduceWaste();
    }
} 
