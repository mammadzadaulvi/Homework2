using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Student : Human
    {
        public int Grade { get; set; }
        public Student()
        {

        }
        public Student(string name, string surname, int age, int grade) : base(name, surname, age)
        {
            Grade = grade;
        }
    }
}
