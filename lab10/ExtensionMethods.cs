using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    static public class ExtensionMethods
    {
        public static(int,int) Podziel (this int dzielna,int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }


        public static int Policz (this string tenString,char szukanaLitera)
        {
            int ile = 0;
            for (int i = 0; i < tenString.Length; i++)
            {
                if (tenString[i] == szukanaLitera)
                {
                    ile++;
                }
            }
            return ile;
        }

        public static int ZliczZnaki(this string text,char character)
        {
            return text.Where(x => x.Equals(character)).Count();
        }


        public static int ZliczZnaki(this string text, char character, bool caseInvariant = true)
        {
           if(!caseInvariant)
            {
                text.ZliczZnaki(character);
            }

           if(char.IsLetter(character))
            {
                return text.ZliczZnaki(char.ToLower(character)) + text.ZliczZnaki(char.ToUpper(character));
            }

            else
            {
              return text.ZliczZnaki(character);
            }


        }

        public static int ZliczZnaki2(this string text, char character, bool caseInvariant = true)
        {
            if (caseInvariant)
            {
                text = text.ToLower();
                character = char.ToLower(character);

            }
            return text.ZliczZnaki(character);

        }

        public static int SumaTypowOsob(this TypOsoby typ)
        {

            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
            

        }

    

    }
}
