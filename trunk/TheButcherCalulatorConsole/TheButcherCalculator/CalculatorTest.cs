using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    class CalculatorTest
    {
        static void Main()
        {
            //Pig test = new Pig("Pig", 300);
            //Console.WriteLine(test.ToString());
            //Cow test2 = new Cow("Cow", 500);
            //Console.WriteLine(test2.ToString());
            
            // Test the lists of produced Goods and Waste for BirddsCattle
            BirdsCattle someDuck = new Duck("Duck", 15);
            BirdsCattle someChicken = new Chicken("Duck", 10);

            List<BirdsCattle> inputList = new List<BirdsCattle>();

            inputList.Add(someChicken);
            inputList.Add(someDuck);
            inputList.Add(new Turkey("Turkey", 20));
            inputList.Add(new Turkey("Turkey", 20));


            List<Product> goods = new List<Product>();
            List<Product> waste = new List<Product>();

            foreach (var item in inputList)
            {
                goods.AddRange(item.ProduceGoods());
                waste.AddRange(item.ProduceWaste());
            }

            Console.WriteLine("Print goods:");
            foreach (var pr in goods)
            {
                Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            }
            Console.WriteLine();

            Console.WriteLine("Print waste:");
            foreach (var pr in waste)
            {
                Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            }
            Console.WriteLine();


            // Try to sum identical products - Successful :-)

            var sumGoods = goods
                .GroupBy(pr => pr.Name.ToString())
                .Select(i => new Product()
                {
                    Name = i.Key,
                    ProductWeight = i.Sum( x => x.ProductWeight)
                })
                .ToList();

            Console.WriteLine();
            Console.WriteLine("Print summed by product Goods List:");
            foreach (var pr in sumGoods)
            {
                Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            }

            var sumWaste = waste
                .GroupBy(pr => pr.Name.ToString())
                .Select(i => new Product()
                {
                    Name = i.Key,
                    ProductWeight = i.Sum( x => x.ProductWeight)
                })
                .ToList();

            Console.WriteLine();
            Console.WriteLine("Print summed by product Waste List:");
            foreach (var pr in sumWaste)
            {
                Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            }

            // Another way that returns List of object[]
            //var sumGoods = goods
            //    .GroupBy(pr => pr.Name.ToString())
            //    .Select(i => new object[]
            //    {
            //        i.Key,
            //        i.Sum( x => x.ProductWeight)
            //    })
            //    .ToList();

            //Console.WriteLine();
            //Console.WriteLine("Print summed by product Goods List:");
            //foreach (var pr in sumGoods)
            //{
            //    Console.WriteLine(string.Format("{0}: {1} kg.", pr[0], pr[1]));
            //}
        }
    }
}
