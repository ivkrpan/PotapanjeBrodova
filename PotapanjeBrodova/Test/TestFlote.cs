using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapanjeBrodova;
namespace Test
{
    [TestClass]
    public class TestFlote
    {
        [TestMethod]
        public void Flota_DodajBrodPovecavaFlotuZaJedanBrod()
        {
            Flota flota = new Flota();
            Assert.AreEqual(0, flota.BrojBrodova);
            flota.DodajBrod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            Assert.AreEqual(1, flota.BrojBrodova);
                }

        [TestMethod]
        public void Flota_GadjajVracaPromajsajZaPoljeKojeNePripadaNitiJednomeBrodu()
        {
            Flota flota = new Flota();
            Assert.AreEqual(0, flota.BrojBrodova);
            flota.DodajBrod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            flota.DodajBrod(new Polje[] { new Polje(5, 6), new Polje(6, 6) });
            Assert.AreEqual(RezultatGadjanja.Promašaj, flota.Gadjaj(new Polje(3, 3)));
        }


        [TestMethod]
        public void Flota_GadjajVracaPogodakZaPrvoPogodjenoPoljeBroda()
        {
            Flota flota = new Flota();
            Assert.AreEqual(0, flota.BrojBrodova);
            flota.DodajBrod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            flota.DodajBrod(new Polje[] { new Polje(5, 6), new Polje(6, 6) });
            Assert.AreEqual(RezultatGadjanja.Pogodak, flota.Gadjaj(new Polje(5,6)));
        }

        [TestMethod]
        public void Flota_GadjajVracaPotopljenZaDrugiPogodakBroda()
        {
            Flota flota = new Flota();
            Assert.AreEqual(0, flota.BrojBrodova);
            flota.DodajBrod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            flota.DodajBrod(new Polje[] { new Polje(5, 6), new Polje(6, 6) });
            Assert.AreEqual(RezultatGadjanja.Pogodak, flota.Gadjaj(new Polje(5, 6)));
            Assert.AreEqual(RezultatGadjanja.Potopljen, flota.Gadjaj(new Polje(6, 6)));
        }
    }
}
