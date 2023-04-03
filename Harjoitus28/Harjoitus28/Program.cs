using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());

            Console.Write("Tulostetaanko parilliset (p) vai parittomat (i)?: ");
            char valinta = Console.ReadLine()[0];

            if (valinta == 'p')
            {
                for (int i = 0; i <= luku; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (valinta == 'i')
            {
                for (int i = 1; i <= luku; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Virheellinen valinta!");
            }

            Console.ReadKey();
        }
    }
}
