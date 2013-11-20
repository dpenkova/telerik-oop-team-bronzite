using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public abstract class FlocksAndHerdsCattle : Animal, ISeparateable
    {
        //properties
        //karantiq
        public virtual double OffalAmount { get; protected set; }
        //but
        public virtual double RoundMeatAmount { get; protected set; }

        public virtual double MeatAmount { get; protected set; }

        //constructor
        protected FlocksAndHerdsCattle(string kind, int totalWeight):base(kind, totalWeight)
        { 
        }

        public abstract List<Product> ProduceGoods();
        public abstract List<Product> ProduceWaste();
    }
}
