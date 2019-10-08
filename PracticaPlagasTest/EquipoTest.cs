using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPlagasTest
{
    [TestClass]
    public class EquipoTest
    {
        [TestMethod]
        public void TestCantidadPeones()
        {
            var peones = new List<string>
            {
                "Peon 1",
                "Peon 2",
                "Peon 3",
            };
            Assert.AreEqual(peones.Count(), 3);
        }
    }
}
