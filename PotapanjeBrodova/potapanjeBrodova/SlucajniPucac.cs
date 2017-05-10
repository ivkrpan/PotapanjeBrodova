using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class SlucajniPucac : IPucac
    {

        public SlucajniPucac(Mreza mreza, int duljinaBroda) {
            this.mreza = mreza;
            this.duljinaBroda = duljinaBroda;

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
        private int duljinaBroda;

        IEnumerable<Polje> IPucac.PogodjanaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
