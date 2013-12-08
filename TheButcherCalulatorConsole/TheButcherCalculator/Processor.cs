using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheButcherCalculator
{
    public class Processor
    {
        public List<ISeparateable> InputList { get; set; }
        public List<Product> GoodsProduced { get; set; }
        public List<Product> WasteProduced { get; set; }

        public Processor()
        {
            this.InputList = new List<ISeparateable>();
            this.GoodsProduced = new List<Product>();
            this.WasteProduced = new List<Product>();
        }

        public void Add(object animalClassAndKind, string textBoxWeightString)
        {
            string strAnimalClassAndKind;
            double weightValue;
            try
            {
                strAnimalClassAndKind = animalClassAndKind.ToString();
            }
            catch (NullReferenceException ex)
            {
                if (textBoxWeightString == string.Empty)
                {
                    throw new AddAnimalException("Please choose an animal and enter its weight !", ex);
                }
                else
                {
                    throw new AddAnimalException("Please choose an animal !", ex);
                }
            }

            try
            {
                weightValue = double.Parse(textBoxWeightString);
            }
            catch (FormatException ex)
            {
                throw new AddAnimalException(String.Format("Please enter the {0}'s weight !", strAnimalClassAndKind.ToLower()), strAnimalClassAndKind, ex);
            }

            string nmespace = animalClassAndKind.GetType().Namespace;
            object assembly = animalClassAndKind.GetType().Assembly;
            string name = string.Format("{0}.{1}, {2}", nmespace, animalClassAndKind, assembly.ToString());

            // Get the type contained in the name string
            Type type = Type.GetType(name, true); // name should be a string of AssemblyQualifiedName

            // Create an instance of that type
            object instance = Activator.CreateInstance(type); // All animals should have an empty constructor to be created this way
            (instance as Animal).TotalWeight = weightValue;
            (instance as Animal).Kind = strAnimalClassAndKind;

            InputList.Add(instance as ISeparateable);
        }

        public void Calculate()
        {
            this.GoodsProduced.Clear();
            this.WasteProduced.Clear();

            foreach (var item in this.InputList)
            {
                this.GoodsProduced.AddRange(item.ProduceGoods());
                this.WasteProduced.AddRange(item.ProduceWaste());
            }

            this.GoodsProduced = SumProducts(GoodsProduced);
            this.WasteProduced = SumProducts(WasteProduced);
        }

        public List<Product> SumProducts(List<Product> input)
        {
            List<Product> sumResult = new List<Product>();
            sumResult = input
               .GroupBy(product => product.Name.ToString())
               .Select(i => new Product()
               {
                   Name = i.Key,
                   ProductWeight = i.Sum(x => x.ProductWeight)
               })
               .ToList();
            return sumResult;
        }

        public void ClearLists()
        {
            this.InputList.Clear();
            this.GoodsProduced.Clear();
            this.WasteProduced.Clear();
        }
    }
}
