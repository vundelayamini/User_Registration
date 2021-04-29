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
            string Email = Console.ReadLine();//Store the input for lastname
            Console.WriteLine(regexValidation.ValidateEmail(Email));
        }
    }
}
