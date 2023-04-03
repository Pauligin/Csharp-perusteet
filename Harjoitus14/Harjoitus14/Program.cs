using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku:");
            int luku = int.Parse(Console.ReadLine());

            if (luku % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen.");
            }
            else
            {
                Console.WriteLine("Luku on pariton.");

                Console.ReadKey();
            }
        }
    }
}
