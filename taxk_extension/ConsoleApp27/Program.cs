using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
