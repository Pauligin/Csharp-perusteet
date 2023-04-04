using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus30
{
    class Program
    {
        static void Main(string[] args)
        {


            //Pyydetään numero käyttäjältä
            Console.Write("Syötä kierroslukumäärä: ");
            int loops = int.Parse(Console.ReadLine());
            int sum = 0;
            //Summataan luvut 0:sta käyttäjän lukuun asti

            for (int i = 0; i < loops; i++)
            {
                //summataan, tarvitaan muuttuja
                sum = sum + i;
            }


            Console.WriteLine($"{loops} kierrosta kertymäksi saatiin: {sum}");


            Console.ReadKey();

        }
    }
}
