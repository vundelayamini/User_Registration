﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class RegexValidation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";//Create pattren for firstname
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";//Create pattren for lastname
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";////Create pattren for  Email
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";//Create pattren for Mobile number 
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";
        public bool ValidateFirstName(string FirstName)//consructor
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
        public bool ValidateLastName(string LastName)//consructor
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool ValidateEmail(string Email)//Constructor
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool ValidateMobile(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}

