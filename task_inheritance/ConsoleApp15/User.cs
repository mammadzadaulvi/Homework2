using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class User
    {
        public string name;
        public string surname;
        public string username;
        public string password;

        public User(string Name, string Surname, string Username, string Password)
        {
            name = Name;
            surname = Surname;
            username = Username;
            password = Password;
        }

        public virtual void GetGrade()
        {
            Console.WriteLine("Bu userdir, student deyil");
        }
    }
}
