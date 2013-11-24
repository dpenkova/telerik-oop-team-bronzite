using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public abstract class SeaCreatures : Animal, ISeparateable 
    {
        //properties
        //karantiq
        public virtual double OffalAmount { get; protected set; }       
        public virtual double MeetAmount { get; protected set; }

        //constructor
        protected SeaCreatures(string kind, double totalWeight)
            : base(kind, totalWeight)
        { 
        }

        protected SeaCreatures()
        { 
        }

        public abstract List<Product> ProduceGoods();
        public abstract List<Product> ProduceWaste();

    }
}
