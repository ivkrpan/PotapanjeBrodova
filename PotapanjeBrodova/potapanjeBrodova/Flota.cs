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
            foreach (Brod brod in brodovi) {
               var rezultat = brod.Gadjaj(polje);
                if (rezultat != RezultatGadjanja.Promašaj) {
                    return rezultat;
                }
            }
            return RezultatGadjanja.Promašaj;
            
        }

        public int BrojBrodova {
            get { return brodovi.Count; }
        }
        
        private List<Brod> brodovi = new List<Brod>();
    }
}
