using System;
using System.Collections.Generic;
using System.Linq;

namespace TheButcherCalculator
{
    class CalculatorTest
    {
        static void Main()
        {
            
            //// Test the lists of produced Goods and Waste for BirddsCattle
            //BirdsCattle someDuck = new Duck("Duck", 4);
            //BirdsCattle someChicken = new Chicken("Duck", 2);

            //List<BirdsCattle> inputList = new List<BirdsCattle>();

            //inputList.Add(someChicken);
            //inputList.Add(someDuck);
            //inputList.Add(new Turkey("Turkey", 6));
            //inputList.Add(new Turkey("Turkey", 5));


            //List<Product> goods = new List<Product>();
            //List<Product> waste = new List<Product>();

            //foreach (var item in inputList)
            //{
            //    goods.AddRange(item.ProduceGoods());
            //    waste.AddRange(item.ProduceWaste());
            //}

            //Console.WriteLine("Print goods:");
            //foreach (var pr in goods)
            //{
            //    Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Print waste:");
            //foreach (var pr in waste)
            //{
            //    Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            //}
            //Console.WriteLine();


            //// Try to sum identical products - Successful :-)

            //var sumGoods = goods
            //    .GroupBy(pr => pr.Name.ToString())
            //    .Select(i => new Product()
            //    {
            //        Name = i.Key,
            //        ProductWeight = i.Sum( x => x.ProductWeight)
            //    })
            //    .ToList();

            //Console.WriteLine();
            //Console.WriteLine("Print summed by product Goods List:");
            //foreach (var pr in sumGoods)
            //{
            //    Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            //}

            //var sumWaste = waste
            //    .GroupBy(pr => pr.Name.ToString())
            //    .Select(i => new Product()
            //    {
            //        Name = i.Key,
            //        ProductWeight = i.Sum( x => x.ProductWeight)
            //    })
            //    .ToList();

            //Console.WriteLine();
            //Console.WriteLine("Print summed by product Waste List:");
            //foreach (var pr in sumWaste)
            //{
            //    Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            //}

            ////Test FlocksAndHerds produced waste and goods
            //List<FlocksAndHerdsCattle> inputL = new List<FlocksAndHerdsCattle>();
            //inputL.Add(new Cow("Sivushka",500));
            //inputL.Add(new Pig("Guci", 300));
            //inputL.Add(new Sheep("Vakla", 70));
            //inputL.Add(new Pig("Pencho", 70));

            //goods.Clear();
            //waste.Clear();

            //foreach (var animal in inputL)
            //{
            //    goods.AddRange(animal.ProduceGoods());
            //    waste.AddRange(animal.ProduceWaste());
            //}

            //Console.WriteLine();
            //Console.WriteLine("------FlocksAndHerdsCattleTest--------");
            //Console.WriteLine();
            //Console.WriteLine("Produced goods:");

            //var sumSimularGoods = goods
            //    .GroupBy(pr => pr.Name.ToString())
            //    .Select(i => new Product()
            //    {
            //        Name = i.Key,
            //        ProductWeight = i.Sum(x => x.ProductWeight)
            //    })
            //    .ToList();
            //foreach (var item in sumSimularGoods)
            //{
            //    Console.WriteLine("{0} {1} kg",item.Name, item.ProductWeight);  
            //}
            //Console.WriteLine("Produced waste:");
            //var sumSimularWaste = waste
            //    .GroupBy(pr => pr.Name.ToString())
            //    .Select(i => new Product()
            //    {
            //        Name = i.Key,
            //        ProductWeight = i.Sum(x => x.ProductWeight)
            //    })
            //    .ToList();
            //foreach (var item in sumSimularWaste)
            //{
            //    Console.WriteLine("{0} {1} kg", item.Name, item.ProductWeight);
            //}


            // Test a List<ISeparateable>

            List<ISeparateable> inputAminals = new List<ISeparateable>();

            inputAminals.Add(new Pig("Pig", 200));
            inputAminals.Add(new Pig("Pig", 250));
            inputAminals.Add(new Cow("Cow", 500));
            inputAminals.Add(new Sheep("Sheep", 150));
            inputAminals.Add(new Chicken("Chicken", 2));
            inputAminals.Add(new Turkey("Turkey", 6));
            inputAminals.Add(new Chicken("Chicken", 1.5));
            inputAminals.Add(new Duck("Duck", 4));
            inputAminals.Add(new Fish("Fish", 16));
            inputAminals.Add(new Crab("Crab", 1));
                        
            List<Product> producedGoods = new List<Product>();
            List<Product> producedWaste = new List<Product>();
            
            foreach (var item in inputAminals)
            {
                producedGoods.AddRange(item.ProduceGoods());
                producedWaste.AddRange(item.ProduceWaste());
            }

            var sumProducedGoods = producedGoods
               .GroupBy(product => product.Name.ToString())
               .Select(i => new Product()
               {
                   Name = i.Key,
                   ProductWeight = i.Sum(x => x.ProductWeight)
               })
               .ToList();

            Console.WriteLine();
            Console.WriteLine("Print summed by product Goods List:");
            foreach (var pr in sumProducedGoods)
            {
                Console.WriteLine(string.Format("{0}: {1} kg.", pr.Name, pr.ProductWeight));
            }

            var sumProduceWaste = producedWaste
                .GroupBy(pr => pr.Name.ToString())
                .Select(w => new Product()
                {
                    Name = w.Key,
                    ProductWeight = w.Sum(x => x.ProductWeight)
                })
                .ToList();

            Console.WriteLine();
            Console.WriteLine("Print summed by product Waste List:");
            foreach (var pr in sumProduceWaste)
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
