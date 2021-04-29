using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UserRegistration
{
    public class Regex
    {
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidateLastName(string firstName)
        {
            return (Regex.Equals(firstName, REGEX_FIRSTNAME));
        }
    }
}
        

       
       