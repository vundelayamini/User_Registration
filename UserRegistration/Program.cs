using System;
using System.Collections.Generic;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration!");

            RegexValidation regexValidation = new RegexValidation();//Create object
            Console.WriteLine("Enter Your First Name::-");//take input from the user
            string FirstName = Console.ReadLine();//Store the input for firstname
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
            Console.WriteLine("Enter Your Last Name::-");//take input from the user
            string LastName = Console.ReadLine();//Store the input for lastname
            Console.WriteLine(regexValidation.ValidateLastName(LastName));
            Console.WriteLine("Enter Your Email :-");//take input from the user
            string Email = Console.ReadLine();//Store the input for email
            Console.WriteLine(regexValidation.ValidateEmail(Email));
            Console.WriteLine("Enter Your Mobile Number::-");//take input from the user
            string MobileNumber = Console.ReadLine();//store the input for mobile number
            Console.WriteLine(regexValidation.ValidateMobile(MobileNumber));
            Console.WriteLine("Enter Your Password");//take input from the user
            string Password = Console.ReadLine();//store the input for password
            Console.WriteLine(regexValidation.ValidatePassword(Password));
            List<string> sampleEmailList = new List<string>()
            {
                "abc@ygmail.com",
                "abc-100@yahoo.com",
                "abc.100@abcd.com",
                "abct111@amit.com",
                "abc-100@gmail.net",
                "abcd.100@abc.com.au",
                "aacdt@1.com",
                "abcdc@gmail.com.com",
                "abcd+100@gmail.com"
            };
            foreach (string item in sampleEmailList)
            {
                if (regexValidation.ValidateEmail(item))
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
          
            }
        }
    }
}

