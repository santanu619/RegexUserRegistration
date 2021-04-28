using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UC3_ValidEmail
    {
        string Regex_ValidEmail = "^[a-z0-9A-Z]+([.#@_][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_ValidEmail);
        }
    }
}
