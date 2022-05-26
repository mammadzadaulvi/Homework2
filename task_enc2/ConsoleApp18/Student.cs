using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Student
    {
        public string Name;
        public string Surname;
        private int[] _grades;

        public int[] Grades
        {
            get
            {
                int j = 0;
                int[] newarray = new int[0];
                for (int i = 0; i < _grades.Length; i++)
                {
                    if (_grades[i] % 2 == 0)
                    {
                        Array.Resize(ref newarray, newarray.Length + 1);
                        newarray[j] = _grades[i];
                        j++;
                    }
                }
                return newarray;
            }
            set
            {
                int j = 0;
                int[] newarray = new int[0];
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        Array.Resize(ref newarray, newarray.Length + 1);
                        newarray[j] = value[i];
                        j++;
                    }
                }
                _grades = newarray;
            }
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
