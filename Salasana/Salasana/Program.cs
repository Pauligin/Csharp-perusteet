using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salasana
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "salasana123";
            bool passwordCorrect = false;

            while (!passwordCorrect)
            {
                Console.Write("Anna salasana: ");
                string password = Console.ReadLine();

                if (password == correctPassword)
                {
                    Console.WriteLine("Salasana oikein!");
                    passwordCorrect = true;
                }
                else
                {
                    Console.WriteLine("Väärä salasana, yritä uudelleen.");
                }
            }

            Console.WriteLine("Ohjelman suoritus päättyy.");

            Console.ReadKey();
        }
    }
}
