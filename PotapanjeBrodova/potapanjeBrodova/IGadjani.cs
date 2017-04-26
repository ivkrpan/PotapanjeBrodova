using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public enum RezultatGadjanja {
        Promašaj,
        Pogodak,
        Potopljen
    }
    interface IGadjani
    {
        RezultatGadjanja Gadjaj(Polje polje);

    }
}
