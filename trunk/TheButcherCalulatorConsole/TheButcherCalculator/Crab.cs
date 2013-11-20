using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Crab : SeaCreatures
    {
        //constant percentiges
        
        private const double wasteWeight = 0.82;
        private const double meat = 0.18;

        // weight calculations for each product

        protected double WasteWeight
        {
            get { return this.TotalWeight * wasteWeight; }
        }

        protected double MeatWeight
        {
            get { return this.TotalWeight * meat; }
        }

        //constructor

        public Crab(string kind,int totalWeight):base(kind, totalWeight)
        {
           
        }

        public override List<Product> ProduceGoods()
        {
            List<Product> producedGoods = new List<Product>();

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
