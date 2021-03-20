using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UserRegistration
{
    public class Regex 
    { 
       public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
       public const string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
       public const string REGEX_EMAIL = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
       public const string REGEX_MOBILENUMBER = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
       //  \S matches any non-whitespace character
      public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";

        public bool ValidateLastName(string lastName)
        {
            return (Regex.Equals(lastName, REGEX_LASTNAME));
        }

        public bool ValidateEmail(string email)
        {
            return (Regex.Equals(email, REGEX_EMAIL));
        }

        public bool ValidateMobile(string mobNumber)
        {
            return (Regex.Equals(mobNumber, REGEX_MOBILENUMBER));
        }

        public bool ValidatePassword(string password)
        {
            return (Regex.Equals(password, REGEX_PASSWORD));
        }

        public bool ValidateLastName(string LastName)
        {
            try
            {
                if (Regex.Equals(LastName, REGEX_LASTNAME))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Sorry Invalid Last Name");
            }
            catch (UserDetailsExeption ex)
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
                    throw new UsersExeption(UserException.ExceptionType.INVALID_EMAIL, "Sorry Invalid Email");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ValidateMobile(string MobileNumber)
        {
            try
            {
                if (Regex.Equals(MobileNumber, REGEX_MOBILENUMBER))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_MOBILE, "Sorry Invalid Mobile Number");
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
                if (Equals(Password, REGEX_PASSWORD))
                    return true;
                else
                    throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Soory Invalid Password");
            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

   
    }
    