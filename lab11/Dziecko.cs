using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
   public class Dziecko
    {
        public DateTime DataUrodzenia { get; set; }
        public double Znizka { get; set; }

        public void Deconstruct (out DateTime dataUr, out double zwolnienie)
        {
            dataUr = DataUrodzenia;
            zwolnienie = Znizka;
        }
    }
}
