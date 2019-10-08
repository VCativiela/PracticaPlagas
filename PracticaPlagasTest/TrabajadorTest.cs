using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPlagasTest
{
    [TestClass]
    public class TrabajadorTest
    {
        [TestMethod]
        public void TestSalarioPositivo()
        {
            var salario = -10.0M;
            Assert.IsTrue(salario >= 0.0M);
        }
    }
}
