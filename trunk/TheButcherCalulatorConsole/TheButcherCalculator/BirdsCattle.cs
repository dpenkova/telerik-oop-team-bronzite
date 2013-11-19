using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public abstract class BirdsCattle : Animal, ISeparateable
    {
        // constants for percentage
        private const double BreastPercentage = 0.3;    // Гърди - 30%
        private const double LegsPercentage = 0.3;      // Бутчета - 30%
        private const double WingsPercentage = 0.1;     // Крила - 10%
        private const double OffalPercentage = 0.1;     // Карантия - 10%
        private const double WastePercentage = 0.1;     // Отпадъци - 10%

        protected double BreastWeight
        {
            get { return this.TotalWeight * BreastPercentage; } 
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

        //public abstract List<Product> ProduceGoods();
        public virtual List<Product> ProduceGoods()
        {
            List<Product> goodsProduced = new List<Product>();

            goodsProduced.Add(new Product("breast", this.BreastWeight));
            goodsProduced.Add(new Product("legs", this.LegsWeight));
            goodsProduced.Add(new Product("wings", this.WingsWeight));
            goodsProduced.Add(new Product("offal weight", this.OffalWeight));

            return goodsProduced;
        }
        
        public abstract List<Product> ProduceWaste();
    }
} 
