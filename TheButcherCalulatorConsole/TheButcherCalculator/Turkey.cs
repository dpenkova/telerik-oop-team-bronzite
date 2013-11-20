using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Turkey : BirdsCattle
   {
        private const double BackPercentage = 0.1;

        protected double BackWeight
        {
            get { return this.TotalWeight * BackPercentage; }
        }

        // constructor
        public Turkey(string animalKind, double totalWeight)
            :base(animalKind, totalWeight)
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
      
            goodsProduced.Add(new Product(string.Format("{0} back", this.GetType().Name), this.BackWeight));

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
