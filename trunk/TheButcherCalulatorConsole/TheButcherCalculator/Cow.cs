using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Cow : FlocksAndHerdsCattle
    {
        //here we set percent constant to calculate weight of different products

        private const double MeatWeightPercentage = 0.35;       //35%
        private const double WasteWeightPercentage = 0.20;      //20%
        private const double OffalWeightPercentage = 0.10;      //10%
        private const double RoundMeаtWeightPercentage = 0.35;  //25%

        //calculating weight of products by piece;
        //methods
        public override List<Product> ProduceGoods()
        {
            //porkProducts.Add(MeetAmount);
            return null;
        }
        public double WasteAmount
        {
            get { return WasteWeightPercentage * TotalWeight; }
        }

        //constructor
        public Cow(string kind, int totalWeight)
            : base(kind, totalWeight)
        {

            base.MeatAmount = MeatWeightPercentage * totalWeight;
            base.OffalAmount = OffalWeightPercentage * totalWeight;
            base.RoundMeat = RoundMeаtWeightPercentage * totalWeight;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
                
            sb.Append("Beef products by kg:");
            sb.Append("-----------------------------");
            sb.Append(Environment.NewLine);
            sb.Append("Meаt amount - " + MeatAmount + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("Offal amount - " + OffalAmount + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("RoundMeаt amount - " + RoundMeat + " kg");
            sb.Append(Environment.NewLine);
            sb.Append("Waste amount - " + WasteAmount + " kg");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            return sb.ToString();

        }

    }
}
