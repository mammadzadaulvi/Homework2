using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    class Student
    {
        public string Name;
        public string Surname;
        private readonly int[] _grades;

        public int[] Grades
        {
            get
            {
                for (int i = 0; i < _grades.Length; i++)
                {
                    if (_grades[i] % 2 == 0)
                    {
                        _grades.Append(_grades[i]);
                    }
                }
                return _grades;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        Console.WriteLine(value[i]);
                    }
                }
            }
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
