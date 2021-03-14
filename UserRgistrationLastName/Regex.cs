using System;
using System.Collections.Generic;
using System.Text;

namespace UserRgistrationLastName
{
    class Regex
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static bool ValidateFirstName(string FirstName) => Regex.IsMatch(FirstName, Regex_FirstName);
        

        public const string Rgex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateLastName(string lastName) => Regex.IsMatch(lastName, Rgex_LastName);
    }
}
