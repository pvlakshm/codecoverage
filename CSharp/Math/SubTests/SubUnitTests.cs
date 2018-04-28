using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace SubTests
{
    [TestClass]
    public class SubUnitTests
    {
        [TestMethod]
        public void subTest1()
        {
            int x = 2;
            int y = 2;
            int diff = 0;

            int res = new Math.Sub().sub(x, y);
            Assert.AreEqual(diff, res);
        }
    }
}
