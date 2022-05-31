using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Student
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public static int age { get; set; }

        public Student()
        {
            age++;
            Age = age;
        }
    }
}
