using System;
using Properties;

namespace AccountCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("hello12@mail.ru", "1aAhsuds");
            user.FullName = "Fazil";
            user.ShowInfo();
        }
    }
}
