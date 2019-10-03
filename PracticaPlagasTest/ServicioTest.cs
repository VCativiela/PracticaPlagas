using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPlagasTest
{
    [TestClass]
    public class ServicioTest
    {
        [TestMethod]
        public void TestPrecioServicio()
        {
            var precioServicio = 30.0M;
            Assert.IsTrue(precioServicio > 0);
        }

        [TestMethod]
        public void TestIngresoServicio()
        {
            var ingresoServicio = 30.0M;
            Assert.IsTrue(ingresoServicio > 0 && ingresoServicio <= 50);
        }
    }
}
