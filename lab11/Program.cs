using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {

        static double ObliczCeneBiletu(object pasazer)
        {
            //if(pasazer is Dziecko dziecko)
            //{
            //    //var dziecko = (Dziecko)pasazer;
            //    Console.WriteLine($"To jest dziecko. Ma znizke {dziecko.Znizka}");
            //}
            //else if (pasazer is OsobaStarsza oStarsza)
            //{
            //    Console.WriteLine("To jest osoba starsza");
            //    if(oStarsza.ZwolnienieZOplaty)
            //    {
            //        Console.WriteLine("Ma darmowe przejazdy");
            //    }
            //}
            switch (pasazer)
            {
                case Dziecko d:
                    Console.WriteLine($"To jest dziecko. Ma znizke {d.Znizka}");
                    break;
                case OsobaStarsza os when os.ZwolnienieZOplaty:
                    Console.WriteLine("To jest osoba starsza " + "Ma darmowe przejazdy");
                    break;
                case OsobaStarsza _:
                    //if (os.ZwolnienieZOplaty)
                    //{
                    //    Console.WriteLine("Ma darmowe przejazdy");
                    //}
                    //break;
                    Console.WriteLine("To jest osoba starsza");
                    break;
                case Rencista r
                    when r.DataKoncaRenty > DateTime.Now:
                    Console.WriteLine($"To jest rencista. Ma znizke {r.Znizka}");
                    break;
                case null:
                    Console.WriteLine("null");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() {DataUrodzenia = new DateTime (2000,01,10), Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplaty = true };
            var rencista = new Rencista() { Znizka = 1, DataKoncaRenty = new DateTime(2020, 10, 10) };
            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1111111",
                ZwolnienieZOplaty = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/121221.jpg"
            };


            //(string legitka,bool znizka,DateTime dataUr, string fotka) = osoba.ZwrocWszystkieDane();

            // var (legitymacja, obnizka, dataUrod, zdjecieRencisty) = osoba.ZwrocWszystkieDane();

            //var temp = osoba.ZwrocWszystkieDane();
            //Console.WriteLine($"{temp.nrLegitymacji} {temp.zwolnienie}");

            //(_, bool zwolnienie, DateTime data, string fotografia) = osoba.ZwrocWszystkieDane();

            var (nrLegitymacji, zwolnienie, dataUr, zdjecie) = osoba;
            var (samNumer, fotka) = osoba;
            var (dataUrod, zwolnieniie) = dziecko;
            //var (znizka, _, typ) = dziecko;
            //Console.WriteLine($"dziecko ma {znizka*100}% znizki bo jest {typ}");
           
            

            #region cw
            Console.WriteLine("Zwykly pasazer");
            ObliczCeneBiletu(pasazer);
            Console.WriteLine("dziecko");
            ObliczCeneBiletu(dziecko);
            Console.WriteLine("emeryt");
            ObliczCeneBiletu(emeryt);
            Console.WriteLine("string");
            ObliczCeneBiletu("pasazer");
            Console.WriteLine("rencista");
            ObliczCeneBiletu(rencista);
            Console.WriteLine("null");
            ObliczCeneBiletu(null);
            #endregion 

        }
    }
}
