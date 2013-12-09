using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Cow : FlocksAndHerdsCattle
    {
        //here we set percent constant to calculate weight of different products
        private const double MeatWeightPercentage = 0.30;       //30%
        private const double WasteWeightPercentage = 0.20;      //20%
        private const double OffalWeightPercentage = 0.10;      //10%
        private const double RoundMeаtWeightPercentage = 0.40;  //45%

        //Properties
        public double WasteAmount
        {
            get { return WasteWeightPercentage * TotalWeight; }
        }
        public override double MeatAmount
        {
            get { return MeatWeightPercentage * TotalWeight; }
        }
        public override double OffalAmount
        {
            get { return OffalWeightPercentage * TotalWeight; }
        }
        public override double RoundMeatAmount
        {
            get { return RoundMeаtWeightPercentage * TotalWeight; }
        }
        //constructor
        public Cow(string kind, double totalWeight)
            : base(kind, totalWeight)
        {
        }

        public Cow()
        { 
        }

        //methods
        public override List<Product> ProduceGoods()
        {
            List<Product> collector = new List<Product>();
            collector.Add(new Product(string.Format("{0} meat",this.GetType().Name),this.MeatAmount));
            collector.Add(new Product(string.Format("{0} round meat", this.GetType().Name), this.RoundMeatAmount));
            collector.Add(new Product(string.Format("{0} offal", this.GetType().Name), this.OffalAmount));
           
            return collector;
        }
        public override List<Product>ProduceWaste()
        {
             List<Product> collectorW = new List<Product>();
            collectorW.Add(new Product(string.Format("{0} waste",this.GetType().Name),this.WasteAmount));
            return collectorW;
        }
    }
}
