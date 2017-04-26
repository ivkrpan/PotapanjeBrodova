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

        [TestMethod]
        public void Brod_GadjajVracaPromasajZaPoljeKojeNePripadaBrodu()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            RezultatGadjanja rez = brod.Gadjaj(new Polje(0, 0));
            Assert.AreEqual(RezultatGadjanja.Promašaj, rez);
        }


        [TestMethod]
        public void Brod_GadjajVracaPogodakZaPrvoPogodjenoPolje()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2), new Polje(1, 3) });
            RezultatGadjanja rez = brod.Gadjaj(new Polje(1, 2));
            Assert.AreEqual(RezultatGadjanja.Pogodak, rez);
        }

        [TestMethod]
        public void Brod_GadjajVracaPogodakZaDrugoPogodjenoPoljeBodaOdTriPolja()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2), new Polje(1, 3) });
            brod.Gadjaj(new Polje(1, 2));
            RezultatGadjanja rez = brod.Gadjaj(new Polje(1, 1));
            Assert.AreEqual(RezultatGadjanja.Pogodak, rez);
        }

        [TestMethod]
        public void Brod_GadjajVracaPotopljenZaTrecePogodjenoPoljebrodaOdTriPolja()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2), new Polje(1, 3) });
            brod.Gadjaj(new Polje(1, 2));
            brod.Gadjaj(new Polje(1, 3));
            RezultatGadjanja rez = brod.Gadjaj(new Polje(1, 1));
            Assert.AreEqual(RezultatGadjanja.Potopljen, rez);
        }

        [TestMethod]
        public void Brod_GadjajVracaPogodakZaDrugoGadjanjeIstogPolja()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2), new Polje(1, 3) });
            brod.Gadjaj(new Polje(1, 2));
            RezultatGadjanja rez = brod.Gadjaj(new Polje(1, 2));
            Assert.AreEqual(RezultatGadjanja.Pogodak, rez);
        }


        [TestMethod]
        public void Brod_GadjajVracaPotopljenZaDrugoGadjanjePotopljenogBroda()
        {
            Brod brod = new Brod(new Polje[] { new Polje(1, 1), new Polje(1, 2), new Polje(1, 3) });
            brod.Gadjaj(new Polje(1, 2));
            brod.Gadjaj(new Polje(1, 3));
            brod.Gadjaj(new Polje(1, 1));
            RezultatGadjanja rez = brod.Gadjaj(new Polje(1, 1));
            Assert.AreEqual(RezultatGadjanja.Potopljen, rez);
        }
    }
}
