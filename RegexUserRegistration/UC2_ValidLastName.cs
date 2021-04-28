using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UC2_ValidLastName
    {
        string Regex_LastName = "^[A - Z]{1}[a - z]{2,10} * $";
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_LastName);
        }
    }
}
