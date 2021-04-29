using System;

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
        }
    }
}
