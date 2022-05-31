
using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tamerlan = new Student();
            Console.WriteLine(tamerlan.Age); //1

            Student faiq = new Student();
            Console.WriteLine(faiq.Age); //2

            Student tural = new Student();
            Console.WriteLine(tural.Age); //3

            Student emil = new Student();
            Console.WriteLine(emil.Age); //4
        }
    }
}
