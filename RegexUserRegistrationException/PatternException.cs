using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistrationException
{
    class PatternException
    {
        private const string FIRST_NAME_REGEX = "^[A-Z][a-zA-Z]{2,}$";
        private const string LAST_NAME_REGEX = "^[A-Z][a-zA-Z]{2,}$";
        private const string EMAIL_REGEX = "^[a-zA-Z]{3}[.]([a-zA-Z]{3})[@][a-zA-Z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z]{2})$";
        private const string MOBILE_REGEX = "^[1-9]{2,2}[][0-9]{10}$";
        private const string PASSWORD_REGEX = "(?=.*[0-9])(?=.*[a-z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool firstNameCheck(string input)
        {
            return Regex.IsMatch(input, FIRST_NAME_REGEX);
        }

        public bool lastNameCheck(string input)
        {
            return Regex.IsMatch(input, LAST_NAME_REGEX);
        }

        public bool EmailCheck(string input)
        {
            return Regex.IsMatch(input, EMAIL_REGEX);
        }

        public bool MobileCheck(string input)
        {
            return Regex.IsMatch(input, MOBILE_REGEX);
        }

        public bool PasswordCheck(string input)
        {
            return Regex.IsMatch(input, PASSWORD_REGEX);
        }
    }
}
