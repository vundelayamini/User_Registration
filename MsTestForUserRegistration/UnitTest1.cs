using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestForUserRegistration
{
    [TestClass]
    public class UnitTest1
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
    }
}