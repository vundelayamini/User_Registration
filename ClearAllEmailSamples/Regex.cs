using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAllEmailSamples
{
    class Regex
    {
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_EMAIL = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public const string REGEX_PHONENUMBER= "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        //  \S matches any non-whitespace character
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
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
        public bool ValidateMobile(string phoneNumber)
        {
            return Regex.Equals(phoneNumber, REGEX_PHONENUMBER);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.Equals(password, REGEX_PASSWORD);
        }
    }
}
