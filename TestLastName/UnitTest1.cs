using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRgistratoinLastname
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void GivenUserFistName_WhenValidate_WhenReturnTrue()
        {
            Program program = new Program();
            bool result = program.validateFirstName("Yamini");
            Assert.AreEqual(true, result);

        }

        public class TestLastName
        {
            public void GivenUserLastName_Whenvalidate_WhenReturnTrue()
            {
                Program program = new Program();
                bool result = program.validatelastName("Mahi");
                Assert.AreEqual(true, result);
            }
        }
    }
}
