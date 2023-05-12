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
            ////String: Etsi kirjaimia merkkijonosta Listaan

            string merkkijono = "Tämä on merkkijono";

            List<(char, int)> charsIncommon = new List<(char, int)>();

            foreach (char c in merkkijono)
            {
                if (char.IsUpper(c))
                {
                    var match = charsIncommon.Find(tuple => tuple.Item1 == c);

                    if (match == default((char, int)))
                    {
                        charsIncommon.Add((c, 1));
                    }
                    else
                    {
                        int count = match.Item2;
                        charsIncommon[charsIncommon.IndexOf(match)] = (c, count + 1);
                    }
                }
            }
            foreach ((char c, int count) in charsIncommon)
            {
                Console.WriteLine($"Merkki {0} esiintyi {1} kertaa", c, count);
            }


            Console.ReadKey();

        }
    }
}
