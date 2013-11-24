using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Sheep : FlocksAndHerdsCattle
    {
        //here we set percent constant to calculate weight of different products
        private const double SheepHeadWeightPercentage=0.05;     //5%
        private const double MeatWeightPercentage = 0.30;       //30%
        private const double WasteWeightPercentage = 0.10;      //15%
        private const double OffalWeightPercentage = 0.20;      //20%
        private const double RoundMeаtWeightPercentage = 0.30;  //30%

        //Properties
        public double SheepHeadWeight
        {
            get { return SheepHeadWeightPercentage * TotalWeight; }
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
        public double WasteAmount
        {
            get { return WasteWeightPercentage * TotalWeight; }
        }
        //constructor
        public Sheep(string kind, double totalWeight)
            : base(kind, totalWeight)
        {
        }

        public Sheep()
        { 
        }

        //methods
        public override List<Product> ProduceGoods()
        {
            List<Product> collector = new List<Product>();
            collector.Add(new Product(string.Format("{0} head", this.GetType().Name), this.SheepHeadWeight));
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
