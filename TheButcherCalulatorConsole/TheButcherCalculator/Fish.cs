using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Fish : SeaCreatures
    {
        //constant percentiges
        private const double HeadWeightPercentage = 0.15;
        private const double TailAndFlippersPercentage = 0.10;
        private const double CaviarWeightPercentage = 0.02;
        private const double WasteWeightPercentage = 0.15;
        private const double MeatWeightPercentage = 0.58;

        // weight calculations for each product

        protected double HeadWeight
        {
            get { return this.TotalWeight * HeadWeightPercentage; }
        }

        protected double TailAndFlippersWeight
        {
            get { return this.TotalWeight * TailAndFlippersPercentage; }
        }

        protected double CaviarWeight
        {
            get { return this.TotalWeight * CaviarWeightPercentage; }
        }

        protected double WasteWeight
        {
            get { return this.TotalWeight * WasteWeightPercentage; }
        }

        protected double MeatWeight
        {
            get { return this.TotalWeight * MeatWeightPercentage; }
        }

        //constructor

        public Fish(string kind, double totalWeight)
            :base(kind, totalWeight)
        {
           
        }

        public Fish()
        { 
        }

        public override List<Product> ProduceGoods()
        {
            List<Product> producedGoods = new List<Product>();

            producedGoods.Add(new Product(string.Format("{0} head ", this.GetType().Name), this.HeadWeight));
            producedGoods.Add(new Product(string.Format("{0} tail and flippers ", this.GetType().Name), this.TailAndFlippersWeight));
            producedGoods.Add(new Product(string.Format("{0} caviar ", this.GetType().Name), this.CaviarWeight));
            producedGoods.Add(new Product(string.Format("{0} meat ", this.GetType().Name), this.MeatWeight));

            return producedGoods;
        }

        public override List<Product> ProduceWaste()
        {
            List<Product> producedWaste = new List<Product>();

            producedWaste.Add(new Product(string.Format("{0} waste ", this.GetType().Name), this.WasteWeight));

            return producedWaste;
        }
    }
}
