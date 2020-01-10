using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Reklama
    {
        public string Tresc;
        private TypOsoby typOsoby;
        private Zainteresowania zainteresowania;

        public void Test()
        {
            if (typOsoby.HasFlag(TypOsoby.Dziecko))
            {
                Console.WriteLine("Ta reklama dla dzieci");
            }
            if (typOsoby < TypOsoby.Dorosly)
            {
                Console.WriteLine("Ta reklama jest dla niepelnoletnich");
            }

            TypOsoby typ;

            for (int i = 0; i <= TypOsoby.Brak.SumaTypowOsob(); i++)
            {
                Console.WriteLine((TypOsoby)i);
            }

            //for (int i = 0; i < 16; i++)
            //{
            //    Console.WriteLine((TypOsoby)i);
            //}



            //foreach (var item in Enum.GetValues(typeof(TypOsoby)))
            //{
            //    Console.WriteLine(item.ToString() + " " + (int)item);
            //}


        }

        public Reklama(string tresc, TypOsoby typOsoby, Zainteresowania zainteresowania)
        {
            Tresc = tresc;
            this.typOsoby = typOsoby;
            this.zainteresowania = zainteresowania;
        }
    }


}
