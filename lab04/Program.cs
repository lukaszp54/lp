using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{

    class Program
    {

     

        static void Main(string[] args)
        {

            string tekst1 = Kalkulator.WczytajLiczbe("1");
            string tekst2 = Kalkulator.WczytajLiczbe("2");
            Console.WriteLine("Podaj operacje: ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            switch (operacja)
            {
                case "+":
                    Console.WriteLine(Kalkulator.Dodaj(tekst1, tekst2));
                    break;
                case "-":
                    Console.WriteLine(Kalkulator.Odejmij(liczba1, liczba2));
                    break;
                case "*":
                    Console.WriteLine(Kalkulator.Pomnoz(liczba1, liczba2));
                    break;
                case "/":
                    Console.WriteLine(Kalkulator.PodzielZWyjatkiem(liczba1, liczba2));
                    break;
             
                    /* double wynik = Podziel(liczba1, liczba2, out rezultat);

                         if (rezultat)
                         {
                             Console.WriteLine(wynik);
                         }
                         else
                         {
                             Console.WriteLine("podzielono przez zero");
                         }

                    try
                    {
                        Console.WriteLine(PodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Podzielono przez zero");
                    }
                    break;
                default:
                    Console.WriteLine("Zla operacja");
                    break;*/

            }
        
        }
    }
    
}
