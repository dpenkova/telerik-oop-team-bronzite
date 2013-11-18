using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public abstract class SeaCreatures : Animal//,IProductable 
    {
        //properties
        //karantiq
        public virtual double OffalAmount { get; protected set; }
        //but
        public virtual double RoundMeet { get; protected set; }

        public virtual double MeetAmount { get; protected set; }

        //constructor
        protected SeaCreatures(string kind, int totalWeight)
            : base(kind, totalWeight)
        { 
        }

        //public abstract void ProduceGoods();
    }
}
