using System;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            while (true)
            {
                Console.WriteLine("1.Product elave edin  2.Product satin");
                string num = Console.ReadLine();
                bool answer2 = int.TryParse(num, out int menu);

                if (answer2)
                {
                    switch (menu)
                    {
                        case 1:
                        flag1:
                            Console.WriteLine("Type: Coffee or Tea?");
                            string type = Console.ReadLine();

                            if (type.ToUpper() != Drink.COFFEE.ToString() && type.ToUpper() != Drink.TEA.ToString())
                            {
                                Console.WriteLine("Yeniden daxil edin");
                                goto flag1;
                            }

                            Console.WriteLine("Product Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Product Price: ");
                            string strprice = Console.ReadLine();
                            double doubleprice = double.Parse(strprice);

                            Console.WriteLine("Product Count: ");
                            string strcount = Console.ReadLine();
                            int intcount = int.Parse(strcount);

                            if (type.ToUpper() == Drink.COFFEE.ToString())
                            {
                                Coffee cofeee = new Coffee(name, intcount, doubleprice);
                                bool isAdded = shop.Add(cofeee);
                                if (isAdded)
                                {
                                    Console.WriteLine("Elave olundu");
                                }
                            }
                            else if (type.ToUpper() == Drink.TEA.ToString())
                            {
                                Tea tea = new Tea(name, intcount, doubleprice);
                                bool isAdded = shop.Add(tea);
                                if (isAdded)
                                {
                                    Console.WriteLine("Elave olundu");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Duzgun daxil edin");
                                goto flag1;
                            }

                            break;
                        
                        case 2:

                            Console.WriteLine("Product Name: ");
                            string productName = Console.ReadLine();

                            Console.WriteLine("Product Price: ");
                            string strproductPrice = Console.ReadLine();

                            int intproductPrice = int.Parse(strproductPrice);
                            shop.Sell(productName, intproductPrice);
                            break;

                        default:
                            break;
                    }
                }
            }
        }
        enum Drink
        {
            COFFEE,
            TEA
        }
    }
}

