using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class User:IAccount
    {

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool PasswordChecker(string password)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            if (password.Length == 8)
            {
                
                foreach (var item in password)
                {
                    if (char.IsUpper(item))
                    {
                        check1 = true;
                        break;
                    }

                    if (char.IsLower(item))
                    {
                        check2 = true;
                        break;
                    }

                    if (char.IsDigit(item))
                    {
                        check3 = true;
                        break;
                    }

                    if(check1 && check2 && check3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName}, Email: {Email}");
        }
    }
}
