using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Sheep : FlocksAndHerdsCattle
    {
        public int SheepHead
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }

        }
        public Sheep(string kind,int totalWeight):base(kind, totalWeight)
        {
            
        }
        public override List<Product> ProduceGoods()
        {
            //porkProducts.Add(MeetAmount);
            return null;
        }
    }
}
