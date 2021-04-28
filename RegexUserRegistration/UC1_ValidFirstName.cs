using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UC1_ValidFirstName
    {
        string Regex_FirstName = "^[A - Z]{1}[a - z]{2,10} * $";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, Regex_FirstName);
        }
    }
}
