using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    class Shop
    {
        public double Totalincome { get; set; }
        public Object[] product;
        public Shop()
        {
            product = new object[0];
        }
        public bool Add(Object obj)
        {
            string answer1 = obj.GetType().Name;
            switch (answer1)
            {
                case "Coffee":
                    {
                        Coffee addCoffee = (Coffee)obj;
                        foreach (var item in product)
                        {
                            if (item.GetType().Name != "Tea")
                            {
                                Coffee coffee = (Coffee)item;
                                if (coffee.Name == addCoffee.Name)
                                {
                                    Console.WriteLine("Elave olundu");
                                    return false;
                                }
                            }
                        }
                        break;
                    }

                case "Tea":
                    {
                        Tea addTea = (Tea)obj;
                        foreach (var item in product)
                        {
                            if (item.GetType().Name != "Coffee")
                            {
                                Tea tea = (Tea)item;
                                if (tea.Name == addTea.Name)
                                {
                                    Console.WriteLine("Elave olundu");
                                    return false;
                                }
                            }
                        }
                        break;
                    }
            }

            Array.Resize(ref product, product.Length + 1);
            product[product.Length - 1] = obj;

            return true;


        }
        public bool Sell(string name, int count)
        {
            if (product.Length == 0)
            {
                Console.WriteLine("Product yoxdur");
                return false;
            }
            foreach (var item in product)
            {
                string type = item.GetType().Name;
                switch (type)
                {
                    case "Coffee":
                        {
                            Coffee coffee = (Coffee)item;
                            if (coffee.Name != name)
                            {
                                Console.WriteLine("Yoxdur");
                                return false;
                            }
                            else if (coffee.Count < count && coffee.Name == name)
                            {
                                Console.WriteLine("Bu qeder yoxdur");
                                return false;
                            }
                            else if (coffee.Name == name)
                            {
                                Totalincome += coffee.Price * count;
                                coffee.Count -= count;
                                if (coffee.Count == 0)
                                {
                                    Console.WriteLine("");
                                }
                                Console.WriteLine("Satildi");
                                return true;
                            }
                            break;
                        }
                    case "Tea":

                    default:
                        break;
                }
            }
            return true;
        }
    }
}
