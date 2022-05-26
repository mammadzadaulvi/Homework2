using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Alfa", "Betta");
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(st.Grades);
            foreach (var item in st.Grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
