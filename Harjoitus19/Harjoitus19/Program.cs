using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus19
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Syötä lämpötila Fahrenheit-asteina:");
            //double fahrenheit = double.Parse(Console.ReadLine());

            //double celsius = (fahrenheit - 32) * 5 / 9;
            //Console.WriteLine("Lämpötila Celsius-asteina on: " + celsius + " °C");



            Console.Write("Syötä lämpötila Celsius-asteina:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Lämpötila Fahrenheit-asteina on: " + fahrenheit + " °F");

            Console.ReadKey();
        }
    }
}
