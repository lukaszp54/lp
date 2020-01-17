using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
   public class OsobaStarsza
    {
        public bool ZwolnienieZOplaty { get; set; }
        public string NrLegitymacji { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }

        public (string nrLegitymacji,bool zwolnienie,DateTime urodziny, string zdjecie) ZwrocWszystkieDane()
        {
            return (NrLegitymacji, ZwolnienieZOplaty, DataUrodzenia, AdresZdjecia);
        }

        public void Deconstruct (out string nrLegitymacji, out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zdjecie = AdresZdjecia;
        }
        public void Deconstruct (out string nrLegitymacji,out bool zwolnienie,out DateTime urodziny,out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zwolnienie = ZwolnienieZOplaty;
            urodziny = DataUrodzenia;
            zdjecie = AdresZdjecia;
        }
    }
}
