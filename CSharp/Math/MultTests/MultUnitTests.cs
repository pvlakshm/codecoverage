using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace MultTests
{
    [TestClass]
    public class MultUnitTest
    {
        [TestMethod]
        public void multTest1()
        {
            int x = 2;
            int y = 2;
            int prod = 4;

            int res = new Math.Mult().mult(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multBasedBusinessLogicTest1()
        {
            int x = 2;
            int y = 1;   // assume this has to be dynamically computed.
            int prod = 2;

            int res = new Math.Mult().multBasedBusinessLogic(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multBasedBusinessLogicTest2()
        {
            int x = 2;
            int y = 2;
            int prod = 4;

            int res = new Math.Mult().multBasedBusinessLogic(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multBasedBusinessLogicTestDefault()
        {
            int x = 2;
            int y = 5;
            int prod = 10;

            int res = new Math.Mult().multBasedBusinessLogic(x, y);
            Assert.AreEqual(prod, res);
        }
    }
}
