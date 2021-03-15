using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClearAllEmailSamples
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            string frstName = "Yamini";
            Console.WriteLine("First name result  is :" + result);

            string LastName = "mahesh";
            Console.WriteLine("Last name result is :" + result);

            string emial = "vudelayamini@gmail.com";
            Console.WriteLine("Email result is :" + result);

            string phoneNumber = "91 9014066209";
            Console.WriteLine("phoneNumber result is :" + result);

            string passWord = "Yamini@mahi";
            Console.WriteLine("passWord result is :" + result);
            

        
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
