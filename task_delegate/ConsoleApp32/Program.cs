using System;
using System.Collections.Generic;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            List<Student> students = new List<Student>();
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("1.Sagird Elave edin: 2.Employee elave edin: 3.Axtaris edin: 4.Exit");
            Console.WriteLine("1-Student elave et");
            Console.WriteLine("2-Employe elave et");
            Console.WriteLine("3-Axtaris et");
            Console.WriteLine("basqa neyese basmaq -Cixis  Menusu gelsin");
            string question = Console.ReadLine();
            bool isInt = int.TryParse(question, out int con);


            switch (con)
            {
                case 1:
                STUDENT:
                    
                    Student student = new Student();
                    
                    Console.WriteLine("Student name: ");
                    string name = Console.ReadLine();
                    student.Name = name;
                    
                    Console.WriteLine("Student surname: ");
                    string surname = Console.ReadLine();
                    student.Surname = surname;
                
                STUDENTAGE:
                    
                    Console.WriteLine("Student age: ");
                    string strage = Console.ReadLine();
                    bool isAge = int.TryParse(strage, out int age);
                    if (!isAge)
                    {
                        Console.WriteLine("Write again");
                        goto STUDENTAGE;
                    }
                    student.Age = age;
                
                GRADE:
                    
                    Console.WriteLine("Student grade: ");
                    string strgrade = Console.ReadLine();
                    bool isGrade = int.TryParse(strgrade, out int grade);
                    if (!isGrade)
                    {
                        Console.WriteLine("Write again");
                        goto GRADE;
                    }
                    student.Grade = grade;
                    students.Add(student);
                    Console.WriteLine("Elave olundu");
                    break;


                case 2:
                
                EMPLOYEE:
                    
                    Employee employee = new Employee();
                    
                    Console.WriteLine("Employee name: ");
                    string empname = Console.ReadLine();
                    employee.Name = empname;
                    
                    Console.WriteLine("Employee surname: ");
                    string empsurname = Console.ReadLine();
                    employee.Surname = empsurname;
                
                EMPLOYEEAGE:
                    
                    Console.WriteLine("Employee age: ");
                    string empage = Console.ReadLine();
                    bool isAge2 = int.TryParse(empage, out int age2);
                    if (!isAge2)
                    {
                        Console.WriteLine("Write again");
                        goto EMPLOYEEAGE;
                    }
                    employee.Age = age2;
                    
                    Console.WriteLine("Employee position: ");
                    string strposition = Console.ReadLine();
                    employee.Position = strposition;
                    employees.Add(employee);
                    
                    Console.WriteLine("Elave olundu");
                    break;

                case 3:
                    
                    Console.WriteLine("1.Employe uzre axtaris");
                    Console.WriteLine("2-Student uzre axtaris");
                    string strquestion = Console.ReadLine();
                    bool isInt2 = int.TryParse(strquestion, out int ans);

                    if (isInt2)
                    {
                        switch (ans)
                        {
                            case 1:
                                if (employees.Count == 0)
                                {
                                    Console.WriteLine("There is 0 employee. Add some employee");
                                    goto EMPLOYEE;
                                }

                                Console.WriteLine("Positions: ");
                                foreach (var item in employees)
                                {
                                    Console.WriteLine((item.Position.ToString()));
                                }

                                Console.WriteLine("Search Employees according to the position");
                                string strpos = Console.ReadLine();

                                foreach (var item in employees)
                                {

                                    if (item.Position == strpos)
                                    {
                                        Console.WriteLine(item.Name);
                                    }


                                }
                                break;
                            
                            case 2:
                                if (students.Count == 0)
                                {
                                    Console.WriteLine("There is 0 student. Add some employees");
                                    goto STUDENT;
                                }

                                Console.WriteLine("MinGrade: ");
                                string strmingrade = Console.ReadLine();
                                int mingrade = int.Parse(strmingrade);

                                Console.WriteLine("MaxGrade: ");
                                string strmaxgrade = Console.ReadLine();
                                int maxgrade = int.Parse(strmaxgrade);

                                foreach (var item in students)
                                {
                                    if (item.Grade >= mingrade && item.Grade <= maxgrade)
                                    {
                                        Console.WriteLine("Student:", item.Name);
                                        Console.WriteLine("Grade:", item.Grade);
                                    }
                                }
                                break;
                            default:
                                break;
                        }

                    }
                    break;
            }
        }
    }
}

