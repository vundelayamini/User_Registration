using System;
using System.Collections.Generic;
using System.Text;

namespace UserEmail
{
    class Regex
    {
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_EMAIL = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.Equals(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.Equals(lastName, REGEX_LASTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.Equals(email, REGEX_EMAIL);
        }
    }

}
