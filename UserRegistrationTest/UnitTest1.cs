using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using UserRegistrationTest;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Regex regex = new Regex("Validate firstname");
            string FirstName = "Amit";
            //Act
            bool result = regex.ValidateFirstName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }
    }
    
}