using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        //calculating weight of products by piece;
        private const int Legs = 4;
        private const int PigEars = 2;      //TODO Un hardcode this
        private const int Pigtail= 1;
        
        //products list-unused!!
        private IList<IProductable> porkProducts;

        public IEnumerable<IProductable> PorkProducts
        {
            get { return this.porkProducts; }
        }

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
        
        public Pig (string kind, int totalWeight):base(kind, totalWeight)
	    {
            base.MeatAmount = MeаtWeightPercentage * totalWeight;
            base.OffalAmount = OffalWeightPercentage * totalWeight;
            base.RoundMeat = RoundMeаtWeightPercentage * totalWeight;

            this.porkProducts = new List<IProductable>();
	    }

        //methods
        public override List<Product> ProduceGoods()
        {
            //porkProducts.Add(MeetAmount);
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pig products by piece :");
            sb.Append("-----------------------------");
            sb.Append(Environment.NewLine);
            sb.Append("Legs - " + Legs + "pieces");
            sb.Append(Environment.NewLine);
            sb.Append("PigEars - " + PigEars + " pieces");
            sb.Append(Environment.NewLine);
            sb.Append("PigTail - " + Pigtail + " pieces");
            sb.Append(Environment.NewLine);
            sb.Append("CommonWeigth ProductsByWeight - " + CommonWeightOfProductByPieceForOneAnimal + " kg");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("Pig products by kg:");
            sb.Append("-----------------------------");
            sb.Append(Environment.NewLine);
            sb.Append("Meаt amount - "+ MeatAmount+" kg");
            sb.Append(Environment.NewLine);
            sb.Append("Bacon amount - " + BaconWeight + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("Offal amount - " + OffalAmount + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("RoundMeаt amount - " + RoundMeat + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("Waste amount - " + WasteAmount  + " kg");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
