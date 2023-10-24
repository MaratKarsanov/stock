using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    public class Stock : IStorage
    {
        public readonly string Name;
        public readonly int Capacity;
        public int LeftCapacity { get; private set; }
        public Dictionary<StockItem, int> Items { get; private set; }

        public Stock(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            LeftCapacity = capacity;
            Items = new Dictionary<StockItem, int>();
        }

        public void AddItem(StockItem item, int count = 1)
        {
            if (LeftCapacity - item.Size * count < 0) 
                throw new InvalidOperationException("На складе нет столько места!");
            LeftCapacity -= item.Size * count;
            if (Items.ContainsKey(item))
                Items[item] += count;
            else
                Items.Add(item, count);
        }

        public StockItem GetItem(StockItem item)
        {
            if (!Items.ContainsKey(item)) return null;
            Items[item]--;
            LeftCapacity += item.Size;
            if (Items[item] == 0) Items.Remove(item);
            return item;
        }

        public StockItem GetItemByName(string itemName)
        {
            foreach(var item in Items)
                if (item.Key.Name == itemName)
                {
                    Items[item.Key]--;
                    LeftCapacity += item.Key.Size;
                    if (Items[item.Key] == 0) Items.Remove(item.Key);
                    return item.Key;
                }
            return null;
        }

        public StockItem GetItemById(int itemId)
        {
            foreach (var item in Items)
                if (item.Key.Id == itemId)
                {
                    Items[item.Key]--;
                    LeftCapacity += item.Key.Size;
                    if (Items[item.Key] == 0) Items.Remove(item.Key);
                    return item.Key;
                }
            return null;
        }
    }
}
