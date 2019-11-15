using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
  
     class Serwer
        {
            public int SzybkoscProcesora { get;private set; }
            public int Lacze { get; private set; }
            public int Ram { get; private set; }
            public string Technologia { get; private set; }

            public Serwer(int szybkoscProcesora, int lacze, int ram, string technologia)
            {
                SzybkoscProcesora = szybkoscProcesora;
                Lacze = lacze;
                Ram = ram;
                Technologia = technologia;
            }
        }

        class Domena
        {

            public string Nazwa { get; private set; }
            public int Waznosc { get; private set; }
                   


            public Domena(string nazwa, int waznosc)
            {
           
                Nazwa = nazwa;
               Waznosc = waznosc;
            }

        }



        // StronaInternetowa
        // Serwer: szybkosc procesora, lacze, ram, technologia
        // Domena: nazwa, waznosc: DateTime;

    }

