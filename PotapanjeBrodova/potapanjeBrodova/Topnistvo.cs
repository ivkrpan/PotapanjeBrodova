﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public enum TaktikaGadjanja {
        Nasumicno,
        Kruzno,
        Linijsko
    }

    public class Topnistvo
    {
        public Topnistvo(int redaka, int stupaca, IEnumerable<int> duljineBrodova) {
            mreza = new Mreza(redaka, stupaca);
            this.duljineBrodova = new List<int>(duljineBrodova);
            TaktikaGadjanja = TaktikaGadjanja.Nasumicno;
            pucac = new SlucajniPucac(mreza, duljineBrodova.First()) ;
    }

        public void ObradiGadjanje(RezultatGadjanja rezultat) {
            if (rezultat == RezultatGadjanja.Promašaj)
            {
                return;
            }

            if (rezultat == RezultatGadjanja.Pogodak)
            {
                switch (TaktikaGadjanja) {

                    case TaktikaGadjanja.Nasumicno:
                        PromijeniTaktikuUKruzno();
                        return;
                    case TaktikaGadjanja.Kruzno:
                        PromijeniTaktikuULinijsko();
                        return;
                    case TaktikaGadjanja.Linijsko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;
                        
                }

            }
            Debug.Assert(rezultat == RezultatGadjanja.Potopljen);
            PromijeniTaktikuUNasumicno();
            
        }

       private  void PromijeniTaktikuUKruzno() {
            TaktikaGadjanja = TaktikaGadjanja.Kruzno;
            Polje pogodjeno = pucac.PogodjanaPolja.First();
            pucac = new KruzniPucac(mreza,pogodjeno,duljineBrodova.First());
         
        }
       private  void PromijeniTaktikuULinijsko() {
            TaktikaGadjanja = TaktikaGadjanja.Linijsko;
            var pogodjeno = pucac.PogodjanaPolja;
            pucac = new LinijskiPucac(mreza, pogodjeno, duljineBrodova.First());
        }
       private  void PromijeniTaktikuUNasumicno() {
            TaktikaGadjanja = TaktikaGadjanja.Nasumicno;
            pucac = new SlucajniPucac(mreza, duljineBrodova.First());
        }


        public TaktikaGadjanja TaktikaGadjanja { get; private set; }

      private  Mreza mreza;
      private  List<int> duljineBrodova;
      private  IPucac pucac;
    }
}
