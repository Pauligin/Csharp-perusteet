using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verolaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee uusi ohjelma, joka kysyy käyttäjältä palkan määrään (brutto) ja veroprosenttia.

            //Lisää metodi, joka ottaa parametreinä palkan(brutto) ja veroprosentin.
            //Metodi palauttaa palkan(nettona).

            //Esim: 1000 ja 10 => 900

            //Extra: Metodi palauttaa nettopalkan lisäksi veron määrän.

            Console.Write("Syötä bruttopalkka: ");
            decimal grossSalary = decimal.Parse(Console.ReadLine());


            Console.Write("Syötä veroprosentti: ");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"Nettopalkka on: {netSalary(grossSalary, taxPercentage)}");

            Console.ReadKey();

        }
        
        private static decimal netSalary(decimal grossSalary, decimal taxPercentage)
        {
            decimal result = 0;
            // tässä välissä lasketaan lopputulos
            result = (grossSalary / 100) * (100 - taxPercentage);


            return result;

        }
    }
}
