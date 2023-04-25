using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //

            // Pyydetään arvot käyttäjältä

            List<Trip> trips = new List<Trip>();

            

            bool userEndsLoop = false;

            while (userEndsLoop == false)

            {
                Console.WriteLine("Syötä matkan nimi: ");
                string name = Console.ReadLine();

                Console.WriteLine("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.WriteLine("Syötä keskikulutus(l/100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.WriteLine("Syötä polttoaineenhinta(e/l): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(name,distance, averageConsumption, fuelPrice));



                Console.Write("Syötetään uusi matka(y): ");
                string input = Console.ReadLine();

                if (input != "y")   //erisuuri !=
                {
                    userEndsLoop = true;
                }
            }

            foreach (Trip t in trips)
            {
                // Lasku toimituksen voisi toteuttaa täällä käyttämällä objektien arvoja
                // Mutta yleensä luokan dataan liittyvät toiminnallisuudet
                // ovat osana itse luokkaa.


                Console.WriteLine($"Matkan {t.Name} hinta on: {t.CalculateCost()}");


            }

            

            Console.ReadKey();
        }
    }
}
