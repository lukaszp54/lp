using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{

    [Flags]
    public enum TypOsoby
    {
        Brak = 0,
        Niemowle =1,
        Dziecko=2,  
        Mlodziez=4, 
        Dorosly=8,  
        Starszy=16   
    }

    enum Zainteresowania
    {
        Elektronika,
        Gaming,
        Motoryzacja         
    }
}
