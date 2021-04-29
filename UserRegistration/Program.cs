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
        }
        
    }
}
