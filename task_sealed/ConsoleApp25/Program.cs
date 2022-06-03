using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int q1 = 1;
            long q2 = 7000000000;
            double q3 = 12.34;
            string q4 = "IsItWork";
            
            Change(q1);
            Change(q2);
            Change(q3);
            Change(q4);
        }
        public static void Change(Object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
