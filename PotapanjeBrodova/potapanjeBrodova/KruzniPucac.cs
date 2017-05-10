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



        private Mreza mreza;
        private Polje prvoPogodjenoPolje;
        private int duljinaBroda;

        IEnumerable<Polje> IPucac.PogodjanaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private IEnumerable<Polje> DajKandidate() {
            List<Polje> kandidati = new List<Polje>();
            
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer))) {
            var  lista= mreza.DajNizSlobodnihPolja(prvoPogodjenoPolje, smjer);

            }
            return kandidati;
        }
    }
}
