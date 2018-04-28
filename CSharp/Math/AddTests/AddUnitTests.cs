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
    }
}
