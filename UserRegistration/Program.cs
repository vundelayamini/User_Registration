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

<<<<<<< HEAD
            List<string> sampleEmailList = new List<string>()
            {
                "ami@ygmail.com",
                "ami-100@yahoo.com",
                "ami.100@abcd.com",
                "amit111@amit.com",
                "ami-100@gmail.net",
                "amit.100@abc.com.au",
                "aamit@1.com",
                "amitc@gmail.com.com",
                "amit+100@gmail.com"
=======
            //Validating Sample Emails
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
>>>>>>> UC9-ClearAllEmailsSamples
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
<<<<<<< HEAD
=======
        
        
>>>>>>> UC9-ClearAllEmailsSamples
