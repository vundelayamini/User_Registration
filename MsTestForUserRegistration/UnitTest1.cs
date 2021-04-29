using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestForUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        private object person;

        [TestMethod]
        public void TestMethod1()
        {
              private object person;

        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            person = new RegexValidation();
        }
        /// <summary>
        /// UC1-Validate for the firstname
        /// </summary>
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string FirstName = "Yamini";
            //Act
            bool result = person.ValidateFirstName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>  
        /// UC2-Valid for LastName
        /// </summary>
        [TestMethod]
        public void GivenUser_LastName_WhenValidate_ShouldReturn_True()
        {
            string LastName = "Mahi";
            //Act
            bool result = person.ValidateLastName(LastName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC3-Valid for Email
        /// </summary>
        [TestMethod]
        public void Given_EmailId_WhenValidate_ShouldReturn_True()
        {
            string Email = "yamini1235@gmail.com";
            //Act
            bool result = person.ValidateEmail(Email);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC4- valid mobile number
        /// </summary>
        [TestMethod]
        public void Given_MobileNumber_WhenValidate_ShouldReturn_True()
        {
            string MobileNumber = "91 9014066209";
            //Act
            bool result = person.ValidateMobile(MobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC5-predefined password
        /// </summary>
        [TestMethod]
        public void Given_Password_WhenValidate_ShouldReturn_True()
        {
            //Arrange
            //All paswoord test case 5/6/7 done in single method
            string Password = "yaminimahi@12";
            //Act
            bool result = person.ValidatePassword(Password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("ami@ygmail.com")]
        [DataRow("ami-100@yahoo.com")]
        [DataRow("ami.100@abcd.com")]
        [DataRow("amit111@amit.com")]
        [DataRow("ami-100@gmail.net")]
        [DataRow("amit.100@abc.com.au")]
        [DataRow("aamit@1.com")]
        [DataRow("amitc@gmail.com.co")]
        [DataRow("amit+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(person.ValidateEmail(email));
        }
    }

}
