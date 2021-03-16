using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserCustomException
{
    class Program
    {

        static void Main(string[] args)
        {
            Regex regex = new Regex();
            string FirstName = "Yamini";
            Console.WriteLine(regex.ValidateFirstName(FirstName));

            string LastName = "Mahesh";
            Console.WriteLine(regex.ValidateLastName(LastName));

            string Email = "vundelayamini@gmail.com";
            Console.WriteLine(regex.ValidateEmail(Email));

            
            string PhoneNumber = "91 9014066209";
            Console.WriteLine(regex.ValidatePhone(PhoneNumber));

            string Password = "yaminiMahi";
            Console.WriteLine(regex.ValidatePassword(Password));


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
            };
            foreach (string item in sampleEmailList)
            {

                if (Regex.validateEmail)
                {
                    Console.WriteLine("valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }

        }
    }
}
