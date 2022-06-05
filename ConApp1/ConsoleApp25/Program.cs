using System;
using ConsoleApp25.Helpers;
using System.Collections.Generic;


namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            Helper.Print("Department name: ", ConsoleColor.Green);
            string strDepartmentName = Console.ReadLine();
            department.Name = strDepartmentName;


            Helper.Print("Total number of employees(Max capacity): ", ConsoleColor.Green);
            flag1:
            string strEmployeeLimit = Console.ReadLine();
            bool boolEmployeeLimit = int.TryParse(strEmployeeLimit, out int intEmployeeLimit);
            if (!boolEmployeeLimit)
            {
                Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                goto flag1;
            }
            department.EmployeeLimit = intEmployeeLimit;


            Helper.Print("Budget: ", ConsoleColor.Green);
            flag2:
            string strBudget = Console.ReadLine();
            bool boolBudget = int.TryParse(strBudget, out int intBudget);
            if (!boolBudget)
            {
                Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                goto flag2;
            }
            department.Budget = intBudget;


            Helper.Print("Required Work Experience (How many years): ", ConsoleColor.Green);
            flag3:
            string strRequiredExperience = Console.ReadLine();
            bool boolRequiredExperience = int.TryParse(strRequiredExperience, out int intRequiredExperience);
            if (!boolRequiredExperience)
            {
                Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                goto flag3;
            }
            department.RequiredExperience = intRequiredExperience;


            Helper.Print("Is Bachelor Degree Required: yes/no", ConsoleColor.Green);
            flag4:
            string strRequiredBachelorDegree = Console.ReadLine();
            if (strRequiredBachelorDegree.ToUpper() == "yes".ToUpper())
            {
                department.IsBachelorDegreeRequired = true;
            }
            else if (strRequiredBachelorDegree.ToUpper() == "no".ToUpper())
            {
                department.IsBachelorDegreeRequired = false;
            }
            else
            {
                Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                goto flag4;
            }

            string answer = default;


            do
            {
                Employee employee = new Employee();
                bool hasBachelorDegree = default;

                Helper.Print("Employee name: ", ConsoleColor.Green);
                string strName = Console.ReadLine();
                employee.Name = strName;
                
                
                Helper.Print("Employee surname: ", ConsoleColor.Green);
                string strSurname = Console.ReadLine();
                employee.Surname = strSurname;
                
                
                Helper.Print("Employee salary: ", ConsoleColor.Green);
                flag5:
                string strSalary = Console.ReadLine();
                bool boolSalary = int.TryParse(strSalary, out int intSalary);
                if (!boolSalary)
                {
                    Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                    goto flag5;
                }
                employee.Salary = intSalary;
                
                
                Helper.Print("Employee work experience(how many years)? ", ConsoleColor.Green);
                flag6:
                string strExperience = Console.ReadLine();
                bool boolExperience = int.TryParse(strExperience, out int intExperience);
                if (!boolExperience)
                {
                    Helper.Print("Duzgun daxil edin", ConsoleColor.Red);
                    goto flag6;
                }
                employee.Experience = intExperience;
                
                
                Helper.Print("Employee has bachelor's degree? ", ConsoleColor.Green);
                string strBachelorDegree = Console.ReadLine();
                if (strBachelorDegree.ToUpper() == "Yes".ToUpper())
                {
                    hasBachelorDegree = true;
                }
                else
                {
                    hasBachelorDegree = false;
                }
                employee.HasBachelorDegree = hasBachelorDegree;



                if (department.AddEmployee(employee))
                {
                    Helper.Print("Employee added ", ConsoleColor.Green);
                }
                else
                {
                    Helper.Print("Employee didn't accepted", ConsoleColor.Red);
                }
                
                Helper.Print("Do you want to add employee: yes/no", ConsoleColor.Blue);
                answer = Console.ReadLine();


            } 
            while (answer.ToUpper() == "yes".ToUpper());

            department.Average();
        }
    }
}
