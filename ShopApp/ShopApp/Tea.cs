﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    class Tea
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Tea(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
