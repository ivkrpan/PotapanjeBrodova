using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
   public class Flota: IGadjani
    {

        public void DodajBrod(IEnumerable<Polje> polja) {
            brodovi.Add(new Brod(polja));
        }

        public RezultatGadjanja Gadjaj(Polje polje)
        {
            throw new NotImplementedException();
        }

        public int BrojBrodova {
            get { return brodovi.Count; }
        }
        
        private List<Brod> brodovi = new List<Brod>();
    }
}
