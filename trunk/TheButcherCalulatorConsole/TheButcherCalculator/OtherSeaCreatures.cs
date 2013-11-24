using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class OtherSeaCreatures : SeaCreatures
    {
        public OtherSeaCreatures(string kind, int totalWeight)
            : base(kind, totalWeight)
        {
            
        }
        public override List<Product> ProduceGoods()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public override List<Product> ProduceWaste()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
