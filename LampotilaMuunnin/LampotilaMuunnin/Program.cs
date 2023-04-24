using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampotilaMuunnin
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Tee uusi ohjelma, joka kysyy käyttäjältä lämpötilan yksikön(C tai F) ja lämpötilan arvon ja muuttaa arvon toiseksi yksiköksi. Muunnoskaava on:

            //C = (5 / 9) * (F - 32)

            //F = C * 9 / 5 + 32

            //Toteuta muunnokset käyttämällä aliohjelmia/ funktioita / metodeja.


            Console.Write("Syötä lämpötila (esim. 25C tai 70F): ");
            string input = Console.ReadLine();

            char unit = input[input.Length - 1];
            double value = double.Parse(input.Substring(0, input.Length - 1));

            if (unit == 'C')
            {
                double fahrenheit = CelsiusToFahrenheit(value);
                Console.WriteLine("{0}C vastaa {1}F", value, fahrenheit);
            }
            else if (unit == 'F')
            {
                double celsius = FahrenheitToCelsius(value);
                Console.WriteLine("{0}F vastaa {1}C", value, celsius);
            }
            else
            {
                Console.WriteLine("Virheellinen syöttö");
            }

            Console.ReadKey();


        }
        static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }




    }
}

