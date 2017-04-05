using System;

using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
namespace Test
{
    [TestClass]
    public class TestTerminatoraPolja
    {
        private Mreza mreza;
        private TerminatorPolja terminator;

        [TestInitialize()]
        public void PirpremiMrezuITerminatora() {
            mreza = new Mreza(10, 10);
            terminator = new TerminatorPolja(mreza);
        }

        [TestMethod]
        public void TermintorPolja_UklanjaSvaPoljaOkoBrodaUSrediniMreze()
        {
            IEnumerable<Polje> polje = new Polje[] { new Polje(3,3), new Polje(3,4) };
            terminator.UkloniPolja(polje);
            Assert.AreEqual(mreza.DajSlobodnaPolja().Count(),88);

            //dodaj provjeru da su izbaceni (3,3) i (3,4), (2,2), (2,5),(2,4),(4,2), (4,5)
        }

        public void TerminatrorPolja_UklanjaSvaPolljaOkoBrodaUzGornjiRubMreze() { }

        public void TerminatrorPolja_UklanjaSvaPolljaUGornjemLijevomKutuMreze() { }
        public void TerminatrorPolja_UklanjaSvaPolljaUGornjemDesnomKutuMreze() { }

        public void TerminatrorPolja_UklanjaSvaPolljaUDoljnjemLijevomKutuMreze() { }
        public void TerminatrorPolja_UklanjaSvaPolljaUDoljnjemDesnomKutuMreze() { }
    }
}
