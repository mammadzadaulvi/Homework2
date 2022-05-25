using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Student : User
    {
        public double Grade;
        public Student(string name, string surname, string username, string password, double grade) : base( name, surname, username, password )
        {
            Grade = grade;
        }
        
        public override void GetGrade()
        {
            Console.WriteLine($"Grade = {Grade}");
        }
    }
}
