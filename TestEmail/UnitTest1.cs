using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using TestEmail;

namespace TestEmail
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void GivenUserFirstName_Whenvalidate_ThenReturnTrue()
        {
            Program program = new Program();
            bool result = program.ValidateFirstName("Yamini");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
         public static void GivenUserLastName_WhenValidate_ThenReturnTrue()
         {
            Program program = new Program();
            bool result = program.ValidateLastName("Mahi");
            Assert.AreEqual(true, result);
 
         }
        [TestMethod]
        public static void GivenUserEmail_Whenvalidate_ThenReturnTrue()
        {
            Program Program = new Program();
            bool result = Program.validateEmail("vundelayamini@gmail.com");
            Assert.AreEqual(true, result);
        }   
    }
}
