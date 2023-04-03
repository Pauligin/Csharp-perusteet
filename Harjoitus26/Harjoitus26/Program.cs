using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                Console.WriteLine("Arvo on 0");
            }
            else if (value > 0)
            {
                Console.WriteLine("Arvo on suurempi kuin 0");
            }
            else
            {
                Console.WriteLine("Arvo on pienempi kuin 0");
            }
        }

    }
}
