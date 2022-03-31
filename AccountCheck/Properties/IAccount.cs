using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
