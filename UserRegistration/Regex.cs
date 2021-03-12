using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Regex
    {
        string pattren = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateLastName(string lastName, Regex_LastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        }
    }
}
