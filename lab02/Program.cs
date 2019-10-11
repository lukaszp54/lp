using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {

        static void Main(string[] args)
        {

            int licznik = 1;
            int[] liczniki = { 1, 1, 1 };

            string linia = string.Empty;
            while (linia != "exit")

            {

                // Console.WriteLine(licznik++);
                linia = Console.ReadLine().ToUpper(); ;

                switch (linia)
                {
                    case "A":
                        Console.WriteLine("A" + liczniki[0]++);
                        licznik++;
                        break;
                    case "B":
                        Console.WriteLine("B" + liczniki[1]++);
                        licznik++;
                        break;
                    case "C":
                        Console.WriteLine("C" + liczniki[2]++);
                        licznik++;
                        break;
                    default:
                        Console.WriteLine("Zły kod produktu");
                        break;
           }


               if (licznik == 10)
                {
                    Console.WriteLine("Max na dzisiaj");
                    break;
                }
            }

            /* Zadanie
             
            double odleglosc = double.MaxValue;
            double suma = 0;
            double licznik = 0;

            while (odleglosc != 0)
            {
                string odlegloscTekst = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscTekst);
                suma += odleglosc;
                licznik++;
            }

            double wynik = (double)suma / (licznik-1);
            Console.WriteLine(wynik);

            */

           
            
            
            //Console.WriteLine("Podaj liczbę:");
            //string odpowiedz = Console.ReadLine();
          
            /* 1 opcja
            
            int liczba = Convert.ToInt32(odpowiedz);

            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta";

            /* 2 opcja
            
            int liczba;
            bool UdaloSie = int.TryParse(odpowiedz, out liczba);

            if (UdaloSie)
            {

                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Parzysta");
                }
                else
                {
                    Console.WriteLine("Nieparzysta");
                }
            }

            else

            { 
                Console.WriteLine("Nie podano liczby");
            }*/

            // ctrl + f5 - konsola czeka na następny ruch

        }
    }

}
   
