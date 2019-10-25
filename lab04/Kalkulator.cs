using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Kalkulator
    {
       public static string WczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj liczbę " + licznik + ":");
            string tekst = Console.ReadLine();
            return tekst;
        }

       public static int Dodaj(int tekst1, int tekst2)
        {
            return tekst1 + tekst2;
        }

       public static int Dodaj(string tekst1, string tekst2)
        {
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);
            return Dodaj(liczba1, liczba2);

        }

        public static int Odejmij(int tekst1, int tekst2)
        {
            return tekst1 - tekst2;
        }

        /// <summary>
        /// funkcja dzielaca 2 liczby (jesli podzielono przez 0; zwraca  0)
        /// </summary>
        /// <param name="tekst1">dzielna</param>
        /// <param name="tekst2">dzielnik</param>
        /// <param name="powodzenie">czy sie udalo dzielenie</param>
        /// <returns></returns>

        public static double Podziel(int tekst1, int tekst2, out bool powodzenie)
        {
            if (tekst2 == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            return (double)tekst1 / tekst2;
        }

        public static double PodzielZWyjatkiem(int tekst1, int tekst2)
        {
            if (tekst2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)tekst1 / tekst2;


        }

        /*  static int Dodaj(int liczba1, int liczba2, int liczba3)
          {

             return Dodaj(Dodaj(liczba1, liczba2), liczba3);
          }*/
         public static int Pomnoz(int tekst1, int tekst2)
        {
            return tekst1 * tekst2;
        }
    }
}
