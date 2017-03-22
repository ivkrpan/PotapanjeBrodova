using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class Mreza
    {
        private int stupaca;
        private int redaka;

        public Mreza(int redaka, int stupaca)
        {
            this.redaka = redaka;
            this.stupaca = stupaca;
            polja = new Polje[redaka, stupaca];
            for (int r =0; r< redaka; r++) {
                for (int s = 0; s < stupaca; s++)
                {
                    polja[r, s] = new Polje(r, s);
                }
            }
        }
        public IEnumerable<Polje> DajSlobodnaPolja()
        {
            List<Polje> p = new List<Polje>();
            for (int r = 0; r < redaka; r++)
            {
                for (int s = 0; s < stupaca; s++)
                {

                    if (polja[r,s] != null) {
                        p.Add(polja[r, s]);

                    }

                }
            }

            return p;
//            throw new NotImplementedException();
        }
        public void UkloniPolje(int redak, int stupca)
        {
            polja[redak, stupca] = null;
 

        }
        public void UkloniPolje(Polje p) {
            polja[p.Redak, p.Stupac] = null;
        }

        private Polje[,] polja;
    }
}
