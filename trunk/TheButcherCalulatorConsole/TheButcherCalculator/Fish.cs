using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Fish : SeaCreatures
    {
        private int head;
        private int tail;
        private int caviar;
        public Fish(string kind,int totalWeight):base(kind, totalWeight)
        {
            
        }
    }
}
