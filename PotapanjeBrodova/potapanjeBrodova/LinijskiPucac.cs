using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class LinijskiPucac : IPucac

    {


        public LinijskiPucac(Mreza mreza, IEnumerable<Polje> pogodjena, int duljinaBroda)
        {
            this.mreza = mreza;
            this.pogodjenaPolja = pogodjena;
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
        private IEnumerable<Polje> pogodjenaPolja;
        private int duljinaBroda;
    }
}
