using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // testaus
           if (CountPositivesSumNegatives(new int[] { 5, 3, 8, -5, -9, 3 }) == new int[] { 4, -14 })
           {
                Console.WriteLine("Metodi toimii.");
           }

            Console.ReadKey();
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            // Luodaan uusi taulukko, johon tallennetaan palautettavat arvot
            int[] result = new int[2];


            // Lasketaan input-taulukosta positiivisien arvojen lukumäärä.
            // for silmukka toimii
            //foreach (int number in input)
            //{
            //    // Tarkistetaan, että arvo on positiivinen
            //    if (number > 0)
            //    {
            //        result[0]++;
            //    }
            //    else
            //    {
            //        result[1] += number;
            //    }
            //}

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    //Kasvatetaan positiivisien arvojen lukumäärän kasvua.
                    result[0]++;
                }
                else // negatiiviset arvot.
                {
                    // summataan negatiiviset arvot.
                    result[1] = result[1] + input[i];
                }
            }

            

            return result; 
        }



    }
}
