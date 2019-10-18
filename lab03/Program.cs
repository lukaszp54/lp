using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {
        static double ObliczSrednia(string[] args)
        {
            string nazwa = string.Empty;
            Console.WriteLine("Podaj nazwe: ");
            nazwa = Console.ReadLine();
            string tekst = String.Empty;
            double suma = 0;
            int licznik = -1;


                    while (tekst != "0")
            {

                tekst = Console.ReadLine();
                double ocena;
                bool czyPrzekonwertowano = double.TryParse(tekst, out ocena);

               

            
                if (czyPrzekonwertowano)
                {

                    if (ocena >= 0 && ocena <= 5)
                    {
                        suma += ocena;
                        licznik++;

                    }
                    else
                    {
                        Console.WriteLine("zla opcja");
                    }

                }
                else
                {
                    Console.WriteLine("podano niepoprawna liczbe");
                }
                    
            }

            double wynik = suma / licznik;

            Console.WriteLine("srednia " + nazwa + "to: " + wynik);
            return wynik;


          

        }
         static void Main(string[] args)
        {

            string[] przedmioty = { "P1", "BOIO", "PTC" };
            double[] srednie = new double[przedmioty.Length];

            for (int i = 0;i < przedmioty.Length; i++)
            {
                srednie[i] = ObliczSrednia(przedmioty[i]);

            }
            double sredniaCalkowita = 0;
            foreach (double sredniaCzastkowa in srednie)
            {
                sredniaCalkowita += sredniaCzastkowa;
            }
            Console.WriteLine("Srednia calkowita: " + sredniaCalkowita / przedmioty.Length);
                }
    }




}
