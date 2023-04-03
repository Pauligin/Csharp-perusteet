using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Lämpötila_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lämpötila Fahrenheit-asteina:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Lämpötila Celsius-asteina on: " + celsius + " °C");

            Console.ReadKey();

        }
    }
}
