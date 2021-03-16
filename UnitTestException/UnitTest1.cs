using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using UnitTestException;

namespace UnitTestException
{
    [TestClass]
    public class Regex
    {

        [TestMethod]
        public void GivenUserFistName_WhenValidated_ThenReturnsTrue()
        {
            string FirstName = "Yamini";
            //Act
            bool result = Regex.validateFirstName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }

    

        [TestMethod]
        public void GivenUserLastName_WhenValidated_ThenReturnsTrue()
        {
            string LastName = "mahi";
            //Act
            bool result = Regex.ValidateLastName(LastName);
            //Assert
            Assert.IsTrue(result);
        }

      

        [TestMethod]
        public void Given_Email_WhenValidated_ThenReturnsTrue()
        {
            string Email = "yamini123@gmail.com";
            //Act
            bool result =Regex.ValidateEmail(Email);
            //Assert
            Assert.IsTrue(result);
        }

      

        [TestMethod]
        public void Given_PhoneNumber_WhenValidated_ThenReturnsTrue()
        {
            string PhoneNumber = "91 9014066209";
            //Act
            bool result = Regex.Validatephone(PhoneNumber);
            //Assert
            Assert.IsTrue(result);
        }

    
        [TestMethod]
        public void Given_Password_WhenValidated_ThenReturnsTrue()
        {
            //Arrange
            //All paswoord test case in single result
            string Password = "yaminimahi";
            //Act
            bool result = Regex.ValidatePassword(Password);
            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        [DataRow("abc@ygmail.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@abcd.com")]
        [DataRow("abc111@amit.com")]
        [DataRow("abc-100@gmail.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.co")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(Regex.ValidateEmail(email));
        }
    }
}




