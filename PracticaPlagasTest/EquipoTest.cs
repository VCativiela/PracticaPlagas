using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPlagasTest
{
    [TestClass]
    public class EquipoTest
    {
        [TestMethod]
        public void TestCantidadPeones()
        {
            int numeroPeones = 3;
            Assert.IsTrue(numeroPeones <= 3 && numeroPeones > 0);
        }
    }
}
