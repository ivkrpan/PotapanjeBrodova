using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestBrodograditelja
    {
        [TestMethod]
        public void Brodograditelj_SložiFlotuVračaFlotuSBrodovimaZadaneDuljine()
        {
            Brodograditelj b = new potapanjeBrodova.Brodograditelj();
            Mreza mreža = new Mreza(10, 10);
            IEnumerable<int> duljineBrodova = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
            Flota f = b.SložiFlotu(mreža, duljineBrodova);
            Assert.AreEqual(duljineBrodova.Count(), f.BrojBrodova);
            //TODO; provjer ima li samo jedan brod duljine 5
            // TODO: provjer ima li samo dva brod duljine 4...
        }
    }
}