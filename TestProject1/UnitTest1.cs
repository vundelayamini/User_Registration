using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidFirstNameUsingTestcase;
using TestProject1;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Regex person;
          
           private readonly Regex Person;
        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            person = new Regex();
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string FirstName = "Yamini";
            //Act
            bool result = UnitTest1.ValidateFirstName(FirstName);
            ///Assert
            Assert.IsTrue(result);

        }

        private static bool ValidateFirstName(string firstName) => throw new NotImplementedException();
    }
}


