using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Samochod
    {
        public static int IloscModeli { get;private set; } = 0;

        public readonly string Model; // tylko do odczytu

        public int VIN { get; private set; }


        //private int _przebieg;

        public int Przebieg { get; private set; }

        public void ZwiekszPrzebieg(int dystans)

        {
            if(dystans < 0)
            {
                throw new ArgumentException("Dystans nie moze byc ujemny");
            }
            Przebieg += dystans;
        }

     /*   public int Przebieg
        {
            get
            {
                return _przebieg;
            }


            set
            {
                if (value > Przebieg)
                {
                    _przebieg = value;
                }
            }

        }*/


        public int IloscDrzwi { get; private set; }



        private int _waga;

        public Samochod(string model, int przebieg, int iloscDrzwi, int waga) :this()
        {
            Model = model;
            Przebieg = przebieg;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
           
        }

        public Samochod(int id)
        {
            
        }

        private Samochod()
        {
            VIN = IloscModeli++;
        }

        public Samochod(int iloscDrzwi, int waga) :this("Multipla",0,iloscDrzwi,waga)
        {

        }


        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if (_waga < 0)
                {
                    _waga = 0;
                }
            }
        }
    }
}
