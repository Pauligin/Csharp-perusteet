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
            Console.Write("Syötä sana: ");

            string word = Console.ReadLine();

            List<(char, int)> charsInCommon = new List<(char, int)>();

            foreach (char c in word)
            {
                int count = 0;
                foreach (char letter in word)
                {
                    if (letter == c)
                        count++;
                }

                charsInCommon.Add((c, count));
            }

            foreach ((char c, int count) in charsInCommon)
            {
                Console.WriteLine($"Kirjain: {c}, Määrä: {count}");
            }

            Console.ReadKey();

        }
    }
}
