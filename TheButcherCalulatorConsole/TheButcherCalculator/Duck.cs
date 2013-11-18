using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Duck : BirdsCattle
    {
        private int duckNeck;
        public Duck(string kind,int totalWeight):base(kind, totalWeight)
        {
            
        }
    }
}
