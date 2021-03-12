using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_ValidLastName
{
   public class Regex
    {
        string pattren = "^[A-Z]{1}[A-Za-z]{2,}$";
        string pattren = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName, Regex_FirstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool ValidateLastName(string lastName, Regex_LastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        }
   }
}
