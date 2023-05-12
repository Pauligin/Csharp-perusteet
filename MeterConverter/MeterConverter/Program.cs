using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä mitta (m): ");
            double meters = double.Parse(Console.ReadLine());


            Console.WriteLine($"{meters}m sentteinä on: {MeterConverter.ToCentimeter(meters)}");

            Console.WriteLine($"{meters}m kilometreinä on: {MeterConverter.ToKilometer(meters)}");

            Console.WriteLine($"{meters}m desimetreinä on: {MeterConverter.ToDecimetre(meters)}");

            Console.WriteLine($"{meters}m tuumana on: {MeterConverter.ToInch(meters)}");

            Console.WriteLine($"{meters}m jalkaa on: {MeterConverter.ToFoot(meters)}");

            Console.WriteLine($"{meters}m jaardia on: {MeterConverter.ToYard(meters)}");


            Console.ReadKey();
        }
    }
}
