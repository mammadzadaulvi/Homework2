using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            
            user.FullName = "Mammadzada Ulvi";
            user.Email = "ulvi@code.edu.az";
            user.Password = "Ulvi1234";
            Console.WriteLine(user.PasswordChecker());
            user.ShowInfo();
        }
    }
}
