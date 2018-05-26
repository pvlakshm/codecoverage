using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SubValidate
{
    [TestClass]
    public class SubValidate
    {
        [TestMethod]
        public void subValidate1()
        {
            int x = 2;
            int y = 2;
            int diff = 10;

            int res = new Math.Sub().sub(x, y);
            Assert.AreEqual(diff, res);
        }
    }
}
