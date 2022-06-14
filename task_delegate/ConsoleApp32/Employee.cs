using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Employee : Human
    {
        public string Position { get; set; }
        public Employee()
        {

        }
        public Employee(string name, string surname, int age, string position) : base(name, surname, age)
        {
            Position = position;
        }
    }
}
