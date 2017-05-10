using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
 public   enum Smjer {
        Desno,
        Dolje,
        Lijevo,
        Gore
    }
    public class Mreza
    {
      //  private int stupaca;
        //private int redaka;
        public readonly int redaka;
        public readonly int stupaca;

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

       public IEnumerable<Polje> DajNizSlobodnihPolja(Polje polje, Smjer smjer)
        {

            switch (smjer) {
                case Smjer.Desno:

                    return DajSlobodnaPoljaDesno(polje); 

                case Smjer.Dolje:
                    return DajSlobodnaPoljaDolje(polje);
                case Smjer.Lijevo:

                    return DajSlobodnaPoljaLijevo(polje);

                case Smjer.Gore:
                    return DajSlobodnaPoljaGore(polje);
                default:
                    Debug.Assert(false);
                    break;

            }

            return new List<Polje>();
        }

        private IEnumerable<Polje> DajSlobodnaPoljaDesno(Polje polje) {

            List<Polje> rezultat = new List<Polje>();
            for (int s = polje.Stupac + 1; s < stupaca;++s) {
                if (polja[polje.Redak, s] == null) 
                  break;
                    rezultat.Add(polja[polje.Redak, s]);
                
            }
            return rezultat;
        }
        private IEnumerable<Polje> DajSlobodnaPoljaLijevo(Polje polje)
        {

            List<Polje> rezultat = new List<Polje>();
            for (int s = polje.Stupac - 1; s >= 0; --s)
            {
                if (polja[polje.Redak, s] == null)
                 break;

                    rezultat.Add(polja[polje.Redak, s]);
                
            }
            return rezultat;
        }
        private IEnumerable<Polje> DajSlobodnaPoljaDolje(Polje polje)
        {
            List<Polje> rezultat = new List<Polje>();
            for (int r = polje.Redak + 1; r < redaka; ++r)
            {
                if (polja[r, polje.Stupac] == null)
                break;
                    rezultat.Add(polja[r, polje.Stupac]);
                
            }
            return rezultat;
        }
        private IEnumerable<Polje> DajSlobodnaPoljaGore(Polje polje)
        {
            List<Polje> rezultat = new List<Polje>();
            for (int r = polje.Redak - 1; r >= 0; --r)
            {
                if (polja[ r, polje.Stupac] == null)
                       break;
                    rezultat.Add(polja[r, polje.Stupac]);
                
            }
            return rezultat;
        }
        public void UkloniPolje(int redak, int stupca)
        {
            polja[redak, stupca] = null;
 

        }
        public void UkloniPolje(Polje p) {
            polja[p.Redak, p.Stupac] = null;
        }

       
        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza) {
            bool nizOK;
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>>();
            List<Polje> niz = new List<Polje>();
            foreach (var p in DajSlobodnaPolja())

            {
            //redak
             nizOK = true;
                for (int i = 0; i < duljinaNiza; i++)
                {
                    if (p.Redak + i < redaka)
                    {
                        Polje testP = polja[p.Redak + i, p.Stupac];
                        if (!DajSlobodnaPolja().Contains(testP))
                        {
                            nizOK = false;
                        } else niz.Add(testP);
                      
                    } else nizOK = false;
         
                }
                if (nizOK == true) nizovi.Add(niz);
                //niz.Clear();
                niz = new List<Polje>();
                //stupac
                nizOK = true;
                for (int i = 0; i < duljinaNiza; i++)
                {
                    if (p.Stupac + i < stupaca)
                    {
                        Polje testP = polja[p.Redak , p.Stupac+i];
                        if (!DajSlobodnaPolja().Contains(testP))
                        {
                            nizOK = false;
                        }
                        else niz.Add(testP);

                    }
                    else nizOK = false;

                }
                if (nizOK == true) nizovi.Add(niz);
                niz = new List<Polje>();

            }
            //  throw new NotImplementedException();
            return nizovi;
        }

        private Polje[,] polja;
    }
}
