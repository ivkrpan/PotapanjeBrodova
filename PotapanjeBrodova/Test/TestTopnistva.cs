using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
namespace Test
{
    [TestClass]
    public class TestTopnistva
    {
        [TestMethod]
        public void Topnistvo_NaPocetkuJeTaktikaNasumicna()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3 ,2 ,1 };
            Topnistvo t = new Topnistvo(redaka,stupaca,duljineBrodova);
            Assert.AreEqual(TaktikaGadjanja.Nasumicno,t.TaktikaGadjanja);
        }

        [TestMethod]
        public void Topnistvo_NasumicnaTaknikaNakonPromasajaOstajeNasumicna()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Promašaj);
            Assert.AreEqual(TaktikaGadjanja.Nasumicno, t.TaktikaGadjanja);
        }

        [TestMethod]
        public void Topnistvo_NasumicnaTaknikaNakonPotapljanjaOstajeNasumicna()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Potopljen);
            Assert.AreEqual(TaktikaGadjanja.Nasumicno, t.TaktikaGadjanja);
        }


        [TestMethod]
        public void Topnistvo_NakonPrvogPogotkaTaktikaPrelaziUKruzno()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            Assert.AreEqual(TaktikaGadjanja.Kruzno, t.TaktikaGadjanja);
        }

        [TestMethod]
        public void Topnistvo_KruznoGadjanjeNakonPromasajaOstajeKruzno()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Promašaj);
            Assert.AreEqual(TaktikaGadjanja.Kruzno, t.TaktikaGadjanja);
        }
        [TestMethod]
        public void Topnistvo_KruznoGadjanjeNakonPogotkaPrelaziULinijsko()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            Assert.AreEqual(TaktikaGadjanja.Linijsko, t.TaktikaGadjanja);
        }
        [TestMethod]
        public void Topnistvo_KruznoGadjanjeNakonPotopaBrodaPrelaziUNasumicno()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Potopljen);
            Assert.AreEqual(TaktikaGadjanja.Nasumicno, t.TaktikaGadjanja);
        }
        [TestMethod]
        public void Topnistvo_LinijskoGadjanjeNakonPromasajaOstajeLinijsko()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Promašaj);
            Assert.AreEqual(TaktikaGadjanja.Linijsko, t.TaktikaGadjanja);
        }
        [TestMethod]
        public void Topnistvo_LinijskoGadjanjeNakonPotopaBrodaPostajeNasumicno()
        {
            int redaka = 5;
            int stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Pogodak);
            t.ObradiGadjanje(RezultatGadjanja.Potopljen);
            Assert.AreEqual(TaktikaGadjanja.Nasumicno, t.TaktikaGadjanja);
        }

    }
}
