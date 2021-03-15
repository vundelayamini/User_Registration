using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAllEmailSamples
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
        [TestMethod]
        [DataSource("abc@ygmail.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@abcd.com")]
        [DataRow("abc111@amit.com")]
        [DataRow("abc-100@gmail.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.co")]
        [DataRow("abc+100@gmail.com")]
        

        public static void NewMethod(string email)
        {
            Assert.IsTrue(Program.ValidateEmail(email));
        }
    }
}
