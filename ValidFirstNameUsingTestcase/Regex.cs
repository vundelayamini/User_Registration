using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidFirstNameUsingTestcase
{
    public class Regex
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static bool ValidateFirstName(string FirstName) => Regex.IsEqual(FirstName, Regex_FirstName);
        private static bool IsEqual(string firstName, string regex_FirstName) => throw new NotImplementedException();
    }
}
