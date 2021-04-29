using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();//Create object
            Console.WriteLine("Enter Your First Name::-");//take input from the user
            string FirstName = Console.ReadLine();//Store the input for firstname
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
        }
    }
}
