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
        public void multTestint1()
        {
            int x = 0;
            int y = 2;
            int prod = 0;

            int res = new Math.Mult().mult(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multTestint2()
        {
            int x = 2;
            int y = 0;
            int prod = 0;

            int res = new Math.Mult().mult(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multTestlong1()
        {
            long x = 0;
            long y = 2;
            long prod = 0;

            long res = new Math.Mult().mult(x, y);
            Assert.AreEqual(prod, res);
        }

        [TestMethod]
        public void multTestlong2()
        {
            long x = 2;
            long y = 0;
            long prod = 0;

            long res = new Math.Mult().mult(x, y);
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
