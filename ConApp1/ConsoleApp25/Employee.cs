using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Employee
    {
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public double Salary { get;  set; }
        public int Experience { get;  set; }
        public bool HasBachelorDegree { get;  set; }


        public Employee()
        {

        }


        public Employee(string name, string surname, double salary, int experience, bool hasbachelordegree) : this()
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Experience = experience;
            HasBachelorDegree = hasbachelordegree;

        }
    }
}
