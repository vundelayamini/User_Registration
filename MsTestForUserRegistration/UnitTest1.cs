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
        }
    }
}
