using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj._31B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku, johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;

            Console.Write("Parillinen / Pariton: ");
            string input = Console.ReadLine();

            while (i <= number)
            {
                if (i % 2 != 0 && input == "Pariton")
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 0 && input == "Parillinen")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta!");
                }
                i++;
            }
        
            Console.ReadKey();
        }
    }
}
