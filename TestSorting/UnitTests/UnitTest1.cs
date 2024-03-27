using NUnit.Framework.Internal;

namespace TestSorting.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool x = true;

            if (!x) Assert.Fail();
        }
    }
}