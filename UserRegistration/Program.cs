using System;
using System.Collections.Generic;

namespace UserRegistration
{
    class Program
     {
        static void Main(string[] args)
        {
            Regex regex = new Regex();
            Console.WriteLine("Enter Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(regex.ValidateFirstName(firstName));
            Console.WriteLine("Enter Your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(regex.ValidateLastName(lastName));
            Console.WriteLine("Enter Your Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(regex.ValidateEmail(email));
            Console.WriteLine("Enter Your Mobile Number");
            string mobileNum = Console.ReadLine();
            Console.WriteLine(regex.ValidateMobile(mobileNum));
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();
            Console.WriteLine(regex.ValidatePassword(password));

            //validating sample Emails
            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            foreach (string item in sampleEmailList)
            {
                if (regex.ValidateEmail(item))
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
