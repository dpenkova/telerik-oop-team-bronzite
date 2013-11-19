using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Chicken : BirdsCattle
{
        private const double LanternPercentage = 0.05;
        private const double HeadPercentage = 0.05;

        protected double LanternWeight
        {
            get { return this.TotalWeight * LanternPercentage; }
        }

        protected double HeadWeight
        {
            get { return this.TotalWeight * HeadPercentage; }
        }

        // constructor
        public Chicken(string animalKind, int totalWeight)
            :base(animalKind, totalWeight)
        { 
        }

        public override List<Product> ProduceGoods()
        {
            List<Product> goodsProduced = new List<Product>();

            goodsProduced.Add(new Product(string.Format("{0} meat", this.GetType().Name), this.MeatWeight));
            goodsProduced.Add(new Product(string.Format("{0} legs", this.GetType().Name), this.LegsWeight));
            goodsProduced.Add(new Product(string.Format("{0} wings", this.GetType().Name), this.WingsWeight));
            goodsProduced.Add(new Product(string.Format("{0} offal weight", this.GetType().Name), this.OffalWeight));

            goodsProduced.Add(new Product(string.Format("{0} head", this.GetType().Name), this.HeadWeight));
            goodsProduced.Add(new Product(string.Format("{0} lantern", this.GetType().Name), this.LanternWeight));

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
