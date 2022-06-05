using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public double Budget { get; set; }
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }


        Employee[] employees = new Employee[0];

        public Department()
        {

        }

        public Department(string name, int employeelimit, double budget, int requiredexperience,bool isbachelordegreerequired) : this()
        {
            Name = name;
            EmployeeLimit = employeelimit;
            Budget = budget;
            RequiredExperience = requiredexperience;
            IsBachelorDegreeRequired = isbachelordegreerequired;
        }

        public bool AddEmployee(Employee employee)
        {
            if (employee.Experience >= RequiredExperience && employee.HasBachelorDegree == IsBachelorDegreeRequired)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;

                double sum = 0;
                foreach (var item in employees)
                {
                    sum += item.Salary;
                }
                if (employees.Length <= EmployeeLimit && sum <= Budget)
                {
                    return true;
                }
            }
            return false;
        }

        public void Average()
        {
            double sum2 = 0;

            foreach (var emp in employees)
            {
                sum2 += emp.Salary;
            }
            int count = employees.Length;
            Console.WriteLine("Average salary: " + sum2 / count);
        }
    }
}
