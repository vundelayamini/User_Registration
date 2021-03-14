using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ValidFirstNameUsingTestcase
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Welcome to my Userregistration form regex ");
            Regex regexValidation = new RegexValidation();
            Console.WriteLine("Enter Your First Name::-");

            string firstName = "Yamini";
            Console.WriteLine(Regex.ValidateFirstName(firstName));
        }
    }

}