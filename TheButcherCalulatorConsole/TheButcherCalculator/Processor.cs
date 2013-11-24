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

        public void Calculate()
        {
            this.GoodsProduced.Clear();
            this.WasteProduced.Clear();

            foreach (var item in this.InputList)
            {
                this.GoodsProduced.AddRange(item.ProduceGoods());
                this.WasteProduced.AddRange(item.ProduceWaste());
            }

            //List<Product> tempGoods = SumProducts(GoodsProduced);
            //this.GoodsProduced.Clear();
            //this.GoodsProduced = tempGoods;

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
