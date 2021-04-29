using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class RegexValidation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";//Create pattren for firstname
        public bool ValidateFirstName(string FirstName)//consructor
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
    }
}

