using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _123
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            int expected = 10;
            int result = Laba1e.Program.Example(x);
            Assert.AreEqual(expected, result);

        }
    }
}
