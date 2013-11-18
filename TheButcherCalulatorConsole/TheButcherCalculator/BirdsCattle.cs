using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public abstract class BirdsCattle : Animal//, IProductable
    {
        //properties
        //karantiq
        public virtual double OffalAmount { get; protected set; }
        //but
        public virtual double RoundMeet { get; protected set; }

        public virtual double MeetAmount { get; protected set; }

        //constructor
        protected BirdsCattle(string kind, int totalWeight)
            : base(kind, totalWeight)
        {
        }
        
       // public abstract List<IProductable> ProduceGoods(Animal animal);

    }
} 
