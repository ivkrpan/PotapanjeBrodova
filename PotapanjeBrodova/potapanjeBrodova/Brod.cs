using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class Brod: IGadjani
    {
        public Brod(IEnumerable<Polje> polja) {
            Polja = polja;

        }

        public RezultatGadjanja Gadjaj(Polje polje)
        {

            if (!Polja.Contains(polje))
                return RezultatGadjanja.Promašaj;
            
                pogodjenaPolja.Add(polje);
                if (pogodjenaPolja.Count == Polja.Count())
                    return RezultatGadjanja.Potopljen;
                return RezultatGadjanja.Pogodak;
                  
            throw new NotImplementedException();
        }
        private HashSet<Polje> pogodjenaPolja = new HashSet<Polje>();

        public readonly IEnumerable<Polje> Polja;
    }
}
