using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class Program
    {

       static void OpiszSamochod(Samochod auto)
        {
            Console.WriteLine("["+auto.VIN+ "] "+auto.Model + ": " + auto.Przebieg + "km " + "Ilosc drzwi: " + auto.IloscDrzwi + " Waga: " + auto.Waga);
        }

        static void Main(string[] args)
        {
            Samochod mojSamochod = new Samochod("Multipla", 10000, 4, 1000);
            Samochod s2 = new Samochod("Multipla", 20000, 2, 2000);
            Samochod s3 = new Samochod("Multipla", 1, 1, 1);
            Samochod nowaMultipla = new Samochod(4, 1000);
            mojSamochod.Waga = 2000;
            mojSamochod.ZwiekszPrzebieg(100);
            OpiszSamochod(mojSamochod);
            OpiszSamochod(s2);
            OpiszSamochod(s3);
            OpiszSamochod(nowaMultipla);
            Console.WriteLine("Wyprodukowano: " + Samochod.IloscModeli);

                Domena nowaDomena = new Domena("D0mena", 1999);
                Serwer nowySerwer = new Serwer(4, 100, 16, "asp.net");
                ProgramStrona.OpiszStrone(nowySerwer, nowaDomena);
            
        }
    }
}
