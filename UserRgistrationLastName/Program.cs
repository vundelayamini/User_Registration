using System;

namespace UserRgistrationLastName
{
    public class Program
    {
        public bool validateName(string name)
        {
            string pattren = "^[A-Z]{1}[A-Za-z]{2,}$";
            bool result = Regex.IsMatch(name, pattren);
            return result;

            string Pattren = "^[A-Z]{1}[A-Za-z]{2,}$";
            bool result = Regex.IsMatch(name, pattren);
            return result;
        }
    }
}
