using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class KruzniPucac : IPucac

    {

        public KruzniPucac(Mreza mreza, Polje pogodjeno, int duljinaBroda) {
            this.mreza= mreza;
            this. prvoPogodjenoPolje = pogodjeno;
            this.duljinaBroda=duljinaBroda;
        }
        public Polje Gadjaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGadjanje(RezultatGadjanja rezultat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Polje> PogodjanaPolja()
        {
            throw new NotImplementedException();
        }

        private Mreza mreza;
        private Polje prvoPogodjenoPolje;
        private int duljinaBroda;
    }
}
