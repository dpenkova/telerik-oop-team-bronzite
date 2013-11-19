using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Turkey : BirdsCattle
   {
        private const double NeckPercentage = 0.05; // TODO: think of something else that differs the turkey of other birds and change this
        private const double PatePercentage = 0.05; // TODO: think of something else that differs the turkey of other birds and change this

        protected double NeckWeight
        {
            get { return this.TotalWeight * NeckPercentage; }
        }

        protected double PateWeight
        {
            get { return this.TotalWeight * PatePercentage; }
        }

        // constructor
        public Turkey(string animalKind, int totalWeight)
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

            goodsProduced.Add(new Product(string.Format("{0} neck", this.GetType().Name), this.NeckWeight));
            goodsProduced.Add(new Product(string.Format("{0} pate", this.GetType().Name), this.PateWeight));

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
