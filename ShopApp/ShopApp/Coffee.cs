using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    class Coffee
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Coffee(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
