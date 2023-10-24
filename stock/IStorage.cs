using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    interface IStorage
    {
        void AddItem(StockItem item, int count);
        StockItem GetItem(StockItem item);
    }
}
