using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticaPlagasTest
{
    [TestClass]
    public class EmpresaTest
    {
        [TestMethod]
        public void TestTotalGastos()
        {
            var gastos = new List<decimal>
            {
                10.0M,
                3.0M,
                20.0M
            };
            Assert.AreEqual(gastos.Sum(), 33.0M);
        }

        [TestMethod]
        public void TestGastoPositivo()
        {
            var gasto = 10.0M;
            Assert.IsTrue(gasto > 0.0M);
        }

        [TestMethod]
        public void TestIngresos()
        {
            var ingresos = new List<decimal>
            {
                10.0M,
                3.0M,
                20.0M
            };
            Assert.AreEqual(ingresos.Sum(), 33.0M);
        }

        [TestMethod]
        public void TestIngresoPositivo()
        {
            var ingreso = 10.0M;
            Assert.IsTrue(ingreso > 0.0M);
        }

        [TestMethod]
        public void TestResultado()
        {
            var ingresos = 40.0M;
            var gastos = 25.0M;
            Assert.AreEqual(Decimal.Subtract(ingresos, gastos), 15.0M);
        }

        [TestMethod]
        public void TestFacturadoCliente()
        {
        }
    }
}
