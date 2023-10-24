using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание склада");
            Console.Write("Введите название: ");
            var stockName = Console.ReadLine();
            Console.Write("Введите вместимость: ");
            var stockCapacity = int.Parse(Console.ReadLine());
            var stock = new Stock(stockName, stockCapacity);
            Console.WriteLine("\nПоздравляю! Теперь у Вас есть склад. Вам доступны следующие операции:");
            Console.WriteLine("1. Положить товар на склад");
            Console.WriteLine("2. Забрать товар со склада");
            Console.WriteLine("3. Забрать товар со склада по названию товара");
            Console.WriteLine("4. Забрать товар со склада по id товара");
            Console.Write("Выберите номер операции: ");
        }
    }
}
