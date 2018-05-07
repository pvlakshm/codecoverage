using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddTests
{
    [TestClass]
    public class AddUnitTests
    {
        [TestMethod]
        public void addTestEvenNumbers()
        {
            int x = 2;
            int y = 2;
            int sum = 4;

            int res = new Math.Add().add(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        public void addTestEvenNumbers2()
        {
            int x = 0;
            int y = 2;
            int sum = 2;

            int res = new Math.Add().add(x, y);
            Assert.AreEqual(sum, res);
        }


        [TestMethod]
        public void addTestEvenNumbers3()
        {
            int x = 2;
            int y = 0;
            int sum = 2;

            int res = new Math.Add().add(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        public void addTestLongEvenNumbers2()
        {
            long x = 0L;
            long y = 2L;
            long sum = 2L;

            long res = new Math.Add().add(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        public void addTestLongEvenNumbers3()
        {
            long x = 2L;
            long y = 0L;
            long sum = 2L;

            long res = new Math.Add().add(x, y);
            Assert.AreEqual(sum, res);
        }
    }
}
