using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin");
            string Username = Console.ReadLine();

            Console.WriteLine("Password daxil edin");
            string Password = Console.ReadLine();


            User[] users = { new Student("Kamil", "Ehmedov", "kamil_ahmedov", "kamill", 90),
                             new Student("Abbas", "Abbasov", "abbas_abbasov", "abbas_02", 95),
                             new User("Celil", "Ehmedov", "celil_ehmedov", "celil_03"),
                             new User("Aydan", "Kazimov", "ayxan_kazimov", "aydan_04")};
            

            bool flag = false;
            foreach (var User in users)
            {
                if (User.username == Username && User.password == Password)
                {
                    flag = true;
                    User.GetGrade();
                }
            }
            if (!flag) Console.WriteLine("Bele User yoxdur");
        }
    }
}
