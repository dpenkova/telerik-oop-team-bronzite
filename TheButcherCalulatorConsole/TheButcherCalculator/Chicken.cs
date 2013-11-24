using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Chicken : BirdsCattle
{
        private const double LanternPercentage = 0.05;  // фенер - 5%
        private const double HeadPercentage = 0.02;     // глава - 2%
        private const double FeetPercentage = 0.02;     // крака - 2%
        private const double TailPercentage = 0.01;     // трътка - 1%


        protected double LanternWeight
        {
            get { return this.TotalWeight * LanternPercentage; }
        }

        protected double HeadWeight
        {
            get { return this.TotalWeight * HeadPercentage; }
        }

        protected double FeetWeight
        {
            get { return this.TotalWeight * FeetPercentage; }
        }

        protected double TailWeight
        {
            get { return this.TotalWeight * TailPercentage; }
        }

        // constructor
        public Chicken(string animalKind, double totalWeight)
            :base(animalKind, totalWeight)
        { 
        }

        public Chicken()
        { 
        }

        public override List<Product> ProduceGoods()
        {
            List<Product> goodsProduced = new List<Product>();
            goodsProduced = base.ProduceGoods();

            foreach (var item in goodsProduced)
            {
                item.Name = string.Format("{0} {1}", this.GetType().Name, item.Name);
            }

            goodsProduced.Add(new Product(string.Format("{0} head", this.GetType().Name), this.HeadWeight));
            goodsProduced.Add(new Product(string.Format("{0} lantern", this.GetType().Name), this.LanternWeight));
            goodsProduced.Add(new Product(string.Format("{0} feet", this.GetType().Name), this.FeetWeight));
            goodsProduced.Add(new Product(string.Format("{0} tail", this.GetType().Name), this.TailWeight));

            return goodsProduced;
        }

        public override List<Product> ProduceWaste()
        {
            List<Product> wasteProduced = new List<Product>();

            wasteProduced.Add(new Product(string.Format("{0} waste", this.GetType().Name), this.WasteWeight));

            return wasteProduced;
        }
    }
}
