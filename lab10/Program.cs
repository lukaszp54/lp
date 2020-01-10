using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int liczba = Convert.ToInt32(Console.ReadLine());
            //(int wynik,int reszta) = liczba.Podziel(3);
            //Console.WriteLine($"{liczba}/3={wynik}r{reszta}");

            //string text = "ala ma kota";
            //Console.WriteLine(text.ZliczZnaki('a'));

            //Console.WriteLine(text,true);


            Reklama reklama = new Reklama("Kup teraz",TypOsoby.Dziecko | TypOsoby.Dorosly | TypOsoby.Mlodziez, Zainteresowania.Elektronika);
            reklama.Test();
            
        }
    }
}
