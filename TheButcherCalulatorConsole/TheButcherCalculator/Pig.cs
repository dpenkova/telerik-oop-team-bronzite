using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    public class Pig : FlocksAndHerdsCattle
    {
        //here we set percent constant to calculate weight of different products
        private const double ProductByPieceWeightPercentage = 0.05;   //5%
        private const double BaconWeightPercentage = 0.15;      //15%
        private const double MeаtWeightPercentage = 0.35;       //35%
        private const double WasteWeightPercentage = 0.10;      //10%
        private const double OffalWeightPercentage = 0.10;      //10%
        private const double RoundMeаtWeightPercentage = 0.25;  //25%

        ////calculating weight of products by piece;
        //private const int Legs = 4;
        //private const int PigEars = 2;      //TODO Un hardcode this
        //private const int Pigtail= 1;
        //properties
        public double CommonWeightOfProductByPieceForOneAnimal
        {
            get { return ProductByPieceWeightPercentage * TotalWeight; }
        }
        public double BaconWeight
        {
            get { return BaconWeightPercentage * TotalWeight; }
        }
        public double WasteAmount
        {
            get { return WasteWeightPercentage * TotalWeight; }
        }
        public override double MeatAmount
        {
            get { return MeаtWeightPercentage * TotalWeight; }
        }
        public override double OffalAmount
        {
            get { return OffalWeightPercentage * TotalWeight; }
        }
        public override double RoundMeatAmount
        {
            get { return RoundMeаtWeightPercentage * TotalWeight; }
        }

        //ctor
        public Pig (string kind, double totalWeight):base(kind, totalWeight)
	    {
	    }

        public Pig()
        { 
        }

        //methods
        public override List<Product> ProduceGoods()
        {
            List<Product> collector = new List<Product>();
            collector.Add(new Product(string.Format("{0} meat",this.GetType().Name),this.MeatAmount));
            collector.Add(new Product(string.Format("{0} bacon", this.GetType().Name), this.BaconWeight));
            collector.Add(new Product(string.Format("{0} round meat", this.GetType().Name), this.RoundMeatAmount));
            collector.Add(new Product(string.Format("{0} offal", this.GetType().Name), this.OffalAmount));
            collector.Add(new Product(string.Format("{0} product by piece common weight", this.GetType().Name), this.CommonWeightOfProductByPieceForOneAnimal));

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
