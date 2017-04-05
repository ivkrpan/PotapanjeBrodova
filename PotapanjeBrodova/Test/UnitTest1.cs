using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
using System.Linq;
namespace Test
{
    [TestClass]
    public class TestBroda
    {
        private Mreza NaprviMrezu() {
            return new Mreza(10,10);
        }

        [TestMethod]
        public void Brod_SadriPoljaZadanaKonstruktorom()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            Assert.AreEqual(2, brod.Polja.Count());
           Assert.IsTrue(brod.Polja.Contains(new Polje(1, 1)));
            Assert.IsTrue(brod.Polja.Contains(new Polje(1, 2)));
        }
    }
}
