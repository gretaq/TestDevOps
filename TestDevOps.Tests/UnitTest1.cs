using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDevOps.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Assert.IsFalse(false, "fail for testing purposis");
        }
    }
}
