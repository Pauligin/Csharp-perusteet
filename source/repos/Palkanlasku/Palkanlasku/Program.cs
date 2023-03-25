using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlasku
{
    class Program
    {
        static void Main(string[] args)
        {

            double tuntipalkka, normaalitunnit, korotetut50tunnit, korotetut100tunnit, palkka;

            Console.Write("Anna tuntipalkka: ");
            tuntipalkka = double.Parse(Console.ReadLine());

            Console.Write("Anna normaalitunnit: ");
            normaalitunnit = double.Parse(Console.ReadLine());

            Console.Write("Anna 50% korotetut tunnit: ");
            korotetut50tunnit = double.Parse(Console.ReadLine());

            Console.Write("Anna 100% korotetut tunnit: ");
            korotetut100tunnit = double.Parse(Console.ReadLine());

            palkka = tuntipalkka * normaalitunnit + tuntipalkka * 1.5 * korotetut50tunnit + tuntipalkka * 2 * korotetut100tunnit;

            Console.WriteLine("Työntekijän palkka on " + palkka + " euroa.");

            Console.ReadKey();

        }
    }
}
