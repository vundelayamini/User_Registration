using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserCustomException
{
    class Regex
    {
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_EMAIL = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public const string REGEX_PHONENUMBER = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";

        public static bool validateEmail { get; internal set; }

        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (Regex.Equals(firstName, REGEX_FIRSTNAME))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME, " Invalid First Name");
            }
            catch (UserException)
            {
                Console.WriteLine(REGEX_FIRSTNAME);
                return false;

            }

        }

       


        public bool ValidateLastName(string LastName)
        {
            try
            {
                if (Regex.Equals(LastName, REGEX_LASTNAME))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ValidateEmail(string Email)
        {
            try
            {
                if (Regex.Equals(Email, REGEX_EMAIL))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ValidatePhone(string PhoneNumber)
        {
            try
            {
                if (Regex.Equals(PhoneNumber, REGEX_PHONENUMBER))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public bool ValidatePassword(string Password)
        {
            try
            {
                if (Regex.Equals(Password, REGEX_PASSWORD))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
