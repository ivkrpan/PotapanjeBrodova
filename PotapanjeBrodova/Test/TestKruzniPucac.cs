using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestKruzniPucac
    {
        [TestMethod]
        public void KruzniPucac_GadjaDajeJednoOdOkolnihPolja()
        {
            Mreza mreza = new Mreza(5, 5);

            KruzniPucac puc = new KruzniPucac(mreza, new Polje(2, 2), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(2, 1), new Polje(3, 2), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gadjano));
                
        }
        [TestMethod]
        public void KruzniPucac_GadjaDajeJednoOdPoljaDesnoIliLijevo()
        {
            Mreza mreza = new Mreza(1, 5);

            KruzniPucac puc = new KruzniPucac(mreza, new Polje(0, 2), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(0, 3)};
            Assert.IsTrue(kandidati.Contains(gadjano));

        }

        [TestMethod]
        public void KruzniPucac_GadjajDajeOkolnaPoljaKojaNisuEliminirana()
        {
            Mreza mreza = new Mreza(5, 5);
            mreza.UkloniPolje(1,2);
            mreza.UkloniPolje(3,2);

            KruzniPucac puc = new KruzniPucac(mreza, new Polje(2, 2), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 1), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gadjano));

        }

        [TestMethod]
        public void KruzniPucac_GadjaDajeJedinoOkolnoPoljeKojeNijeEliminirano()
        {
            Mreza mreza = new Mreza(5, 5);
            mreza.UkloniPolje(1, 2);
            mreza.UkloniPolje(3, 2);
            mreza.UkloniPolje(2, 1);
            KruzniPucac puc = new KruzniPucac(mreza, new Polje(2, 2), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje> {  new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gadjano));

        }

        [TestMethod]
        public void KruzniPucac_GadjaDajePoljaDesnoIIspodZaPogodjenoPoljeUGornjemLijevomKutu()
        {
            Mreza mreza = new Mreza(5, 5);
            KruzniPucac puc = new KruzniPucac(mreza, new Polje(0, 0), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1) , new Polje (1,0) };
            Assert.IsTrue(kandidati.Contains(gadjano));

        }
        [TestMethod]
        public void KruzniPucac_GadjaDajePoljaLijevoIznadZaPogodjeoPoljeUDoljnjemDesnomKutu()
        {
            Mreza mreza = new Mreza(5, 5);
       
            KruzniPucac puc = new KruzniPucac(mreza, new Polje(4, 4), 3);
            Polje gadjano = puc.Gadjaj();
            List<Polje> kandidati = new List<Polje>  { new Polje(0, 1), new Polje(1, 0) };
            Assert.IsTrue(kandidati.Contains(gadjano));

        }
    }
}
