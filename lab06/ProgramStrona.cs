using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class ProgramStrona
    {
        static void OpiszStrone(Serwer serwer, Domena domena)
        {
            Console.WriteLine(domena.Nazwa + ", Data waznosci: " + domena.Waznosc);
            Console.WriteLine("Parametry serwera: " + serwer.SzybkoscProcesora + " " + serwer.Lacze + " " + serwer.Ram + " " + serwer.Technologia);
        }
        static void Main(string[] args)
        {
            Domena nowaDomena = new Domena("D0mena", 1999);
            Serwer nowySerwer = new Serwer(4, 100, 16, "asp.net");
            OpiszStrone(nowySerwer, nowaDomena);
        }
    }
}
