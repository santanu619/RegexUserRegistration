using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UC4_ValidPassword
    {
        string Regex_ValidPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_ValidPassword);
        }
    }
}
