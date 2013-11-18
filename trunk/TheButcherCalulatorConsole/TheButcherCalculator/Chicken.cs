using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public class Chicken : BirdsCattle
    {
        private int chickenWings;
        private int chickenNeck;
        public Chicken(string kind,int totalWeight):base(kind, totalWeight)
        {
            
        }
       
    }
}
