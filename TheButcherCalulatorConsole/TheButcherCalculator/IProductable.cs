using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheButcherCalculator
{
    public interface IProductable : ISeparatable
    {
        List<IProductable> ProduceGoods(Animal animal);
    }
}
