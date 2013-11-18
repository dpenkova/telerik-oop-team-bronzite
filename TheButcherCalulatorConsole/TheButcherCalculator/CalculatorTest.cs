using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheButcherCalculator
{
    class CalculatorTest
    {
        static void Main()
        {
            Pig test = new Pig("Pig", 300);
            Console.WriteLine(test.ToString());
            Cow test2 = new Cow("Cow", 500);
            Console.WriteLine(test2.ToString());
        }
    }
}
