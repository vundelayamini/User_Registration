using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPassWordForRule3
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
        [TestMethod]
        public static void GivenUserPhoneNumber_Whenvalidate_ThenReturnTrue()
        {
            Program program = new Program();
            bool result = Program.validatePhoneNumber("91 9014066209");
            Assert.AreEqual(true, result);
        }
        [TestMethod]

        public static void GivenUserPassWord_Whenvalidate_ThenReturnTrue()
        {
            Program program = new Program();
            bool result = program.validatePassWord("yaminiMahi");
            Assert.AreEqual(true, result);
        }
    }
}
