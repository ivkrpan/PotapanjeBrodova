using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potapanjeBrodova
{
    public class Class1
    {
       static void Main() {

         Mreza m = new Mreza(5, 1);
         Console.WriteLine(m.DajNizoveSlobodnihPolja(3).Count());
            Console.ReadLine();
        }
    }
}
