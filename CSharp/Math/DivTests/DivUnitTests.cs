using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace DivTests
{
    [TestClass]
    public class DivUnitTests
    {
        [TestMethod]
        public void divTest1()
        {
            int x = 2;
            int y = 2;
            int quot = 1;

            int res = new Math.Div().div(x, y);
            Assert.AreEqual(quot, res);
        }
    }
}
