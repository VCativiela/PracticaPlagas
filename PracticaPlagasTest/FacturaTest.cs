using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPlagasTest
{
    [TestClass]
    public class FacturaTest
    {
        [TestMethod]
        public void TestTotalFacturaPositivo()
        {
            var totalFactura = 0.0M;
            Assert.IsTrue(totalFactura > 0.0M);
        }
    }
}
