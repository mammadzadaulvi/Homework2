using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    public interface IAccount
    {
        public abstract bool PasswordChecker();
        public abstract void ShowInfo();
    }
    class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool PasswordChecker()
        {
            int LowerCount = 0;
            int UpperCount = 0;
            int DigitCount = 0;
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password.Length > 7)
                {
                    if (Char.IsLower(Password[i]))
                    {
                        LowerCount++;
                    }
                    else if (Char.IsUpper(Password[i]))
                    {
                        UpperCount++;
                    }
                    else if (Char.IsDigit(Password[i]))
                    {
                        DigitCount++;
                    }
                    if (LowerCount > 0 && UpperCount > 0 && DigitCount > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
