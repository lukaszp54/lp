using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class ProgramStrona
    {
       public static void OpiszStrone(Serwer serwer, Domena domena)
        {
            Console.WriteLine(domena.Nazwa + ", Data waznosci: " + domena.Waznosc);
            Console.WriteLine("Parametry serwera: " + serwer.SzybkoscProcesora + " " + serwer.Lacze + " " + serwer.Ram + " " + serwer.Technologia);
        }

    }
}
