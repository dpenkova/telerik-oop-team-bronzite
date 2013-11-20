using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Duck : BirdsCattle
    {
        private const double NeckPercentage = 0.05;
        private const double PatePercentage = 0.05;

        protected double NeckWeight
        {
            get { return this.TotalWeight * NeckPercentage; }
        }

        protected double PateWeight
        {
            get { return this.TotalWeight * PatePercentage; }
        }

        // constructor
        public Duck(string animalKind, double totalWeight)
            :base(animalKind, totalWeight)
        { 
        }

        // Replaced with the bottom one
        //public override List<Product> ProduceGoods()
        //{
        //    List<Product> goodsProduced = new List<Product>();

        //    goodsProduced.Add(new Product(string.Format("{0} meat", this.GetType().Name), this.MeatWeight));
        //    goodsProduced.Add(new Product(string.Format("{0} legs", this.GetType().Name), this.LegsWeight));
        //    goodsProduced.Add(new Product(string.Format("{0} wings", this.GetType().Name), this.WingsWeight));
        //    goodsProduced.Add(new Product(string.Format("{0} offal weight", this.GetType().Name), this.OffalWeight));

        //    goodsProduced.Add(new Product(string.Format("{0} neck", this.GetType().Name), this.NeckWeight));
        //    goodsProduced.Add(new Product(string.Format("{0} pate", this.GetType().Name), this.PateWeight));

        //    return goodsProduced;
        //}

        // using the ProduceGoods() method from the base class
        public override List<Product> ProduceGoods()
        {
            List<Product> goodsProduced = new List<Product>();
            goodsProduced = base.ProduceGoods();

            foreach (var item in goodsProduced)
            {
                item.Name = string.Format("{0} {1}", this.GetType().Name, item.Name);
            }

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
