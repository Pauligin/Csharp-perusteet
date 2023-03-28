using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuotteen myyntihinnasta annetaan alennusta 10% ja, jos hinta on yli 100 euroa alennus on 25%.
            //Tee ohjelma joka laskee annetusta hinnasta tuotteen lopullisen myyntihinnan

            Console.Write("Syötä hinta: ");
            double price = double.Parse(Console.ReadLine());
            double discountedPrice;

            if (price > 100)
            {
                discountedPrice = price * 0.75; //  25% ale
            }
            else
            {
                discountedPrice = price * 0.90; //  10% ale
            }

            Console.WriteLine($"Alennettu hinta on {discountedPrice} euroa");

            Console.ReadKey();

        }
    }
}
