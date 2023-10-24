using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    public class StockItem : IProduct
    {
        public readonly string Name;
        public readonly int Id;
        public readonly int Size;
        public readonly int Price;
        public StockItem(string name = "", int id = -1, int size = 0, int price = 0)
        {
            Name = name;
            Id = id;
            Size = size;
            Price = price;
        }
    }
}
