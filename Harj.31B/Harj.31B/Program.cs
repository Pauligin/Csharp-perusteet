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
            //31B C# Toisto: Lukujen summa ja keskiarvo

            Console.Write("Montako lukua summataan: ");
            int numbersToSum = int.Parse(Console.ReadLine());
            double sum = 0; // luodaan summa muuttuja silmukan ulkopuolella,
                         // muuten muuttuja aina resetoituu.

            //k:4, 0, 1, 2, 3 => 4 kierrosta
            for(int i = 0; i < numbersToSum; i++)
            {
                Console.Write($"Anna luku {i}: ");
                sum = sum + int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summa on: {sum} ja summan keskiarvo on: {sum / numbersToSum}");

            Console.ReadKey();
        }
    }
}
