using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //String: Etsi kirjaimia merkkijonosta Listaan

            string merkkijono1 = "Tämä on ensimmäinen merkkijono";
            string merkkijono2 = "Tämä on toinen merkkijono";
            List<(char, int)> charsNotInCommon = new List<(char, int)>();

            foreach (char c in merkkijono1 + merkkijono2)
            {
                if (!merkkijono1.Contains(c) || !merkkijono2.Contains(c))
                {
                    charsNotInCommon.Add((c, (merkkijono1 + merkkijono2).IndexOf(c)));
                }
            }

            Console.ReadKey();

        }
    }
}
