using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using UserRegistrationTest;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private Regex user;

        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            user = new Regex();
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string firstName = "Yamini";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            string lastName = "Mahi";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            string email = "yamini@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            string mobileNumber = "91 9493499430";
            //Act
            bool result = user.ValidateMobile(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange

            string password = "yaminimahi";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            string firstName = "yamini";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            string lastName = "Mahi";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            string email = "yaminivundela@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            string mobileNumber = "91 9014066209";
            //Act
            bool result = user.ValidateMobile(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            string password = "yaminimahi*124";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
    }

  
}