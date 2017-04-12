using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class TerminatorPolja
    {
        public TerminatorPolja(Mreza mreza) {
            this.mreza = mreza;
        }
        public void UkloniPolja(IEnumerable<Polje> polja)
        {
            //bla bla

            //   mreza.UkloniPolje(r, s);
            IEnumerable<Polje> sortirana = polja.Sortiraj();
            int r0 = Math.Max(sortirana.First().Redak - 1, 0);
            int s0 = Math.Max(sortirana.First().Stupac - 1, 0);
            int r1 = Math.Min(sortirana.Last().Redak + 2, mreza.redaka);
            int s1 = Math.Min(sortirana.Last().Stupac + 2, mreza.stupaca);
            for (int r = r0; r < r1; ++r)
                for (int s = s0; s < s1; ++s)
                    mreza.UkloniPolje(r, s);
        }
        private Mreza mreza;
    }
}
