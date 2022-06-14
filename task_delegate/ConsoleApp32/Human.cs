using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }
        public Human(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
