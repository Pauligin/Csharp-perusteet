using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikkienAiheidenKertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Datatyypit
            #region
            //int age = 7;
            //string carBrand = "Volvo";
            //double kilometers = 100000;
            //char carQuality = 'A';
            //bool CarIsFast = true;

            //Console.WriteLine($"Automerkki on {carBrand} ja se on {age} vuotta vanha. " +
            //    $"Autolla on ajettu {kilometers} kilometriä. Auton laatu on {carQuality}-luokkaa ");

            //Console.ReadKey();
            #endregion

            //2. Valintarakenteet
            #region
            //Console.Write("Kuinka paljon sinun autollasi on ajettu? ");
            //double carMiles = double.Parse(Console.ReadLine());
            //if (carMiles < 99999)
            //{
            //    Console.WriteLine("Sinun autolla ei ole ajettu älyttömästi!");
            //}
            //else if (carMiles < 500000)
            //{
            //    Console.WriteLine("Sinun autolla rupee olemaan jo kilometrejä takana!");
            //}
            //else
            //{
            //    Console.WriteLine("Sinun auto joutaisi jo romuttamolle!");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Valitse jompikumpi autoista nro: 1 (Mese) vai 2 (Pösö)");
            //string carNumber = Console.ReadLine();
            //switch (carNumber)
            //{
            //    case "1":
            //        Console.WriteLine("Valitsit Mesen");
            //        break;
            //    case "2":
            //        Console.WriteLine("Valitsit Pösön");
            //        break;
            //    default:
            //        Console.WriteLine("Virheellinen valinta!");
            //        break;
            //}
            //Console.ReadLine();
            #endregion

            //3. Silmukat + List
            #region
            //string userInput = "kyllä";
            //while (userInput == "kyllä")
            //{
            //    Console.Write("Syötä auton merkki:");
            //    string merkki = Console.ReadLine();

            //    Console.WriteLine("Syötä auton malli:");
            //    string malli = Console.ReadLine();

            //    Console.WriteLine($"Valitsit auton {merkki} {malli}");

            //    Console.WriteLine("Syötä (kyllä) jos haluat valita uuden auton, muutoin mukavaa päivänjatkoa!");
            //    userInput = Console.ReadLine();
            //}


            //List<string> carBrands = new List<string>() { "Toyota", "Ford", "Nissan" };

            //Console.WriteLine("Automerkit:");
            //foreach (string brand in carBrands)
            //{
            //    Console.WriteLine(brand);
            //}

            //Console.ReadKey();
            #endregion

            //4. Taulukot ja listat + For
            #region
            //int autotallinKoko = 3;
            //string[] autot = new string[autotallinKoko];
            //for (int i = 0; i < autot.Length; i++)
            //{
            //    Console.Write($"Syötä auton {i + 1}. merkki: ");
            //    autot[i] = Console.ReadLine();
            //}
            //Console.WriteLine("\nAutotallista löytyy:");
            //for (int i = 0; i < autot.Length; i++)
            //{
            //    Console.WriteLine($"Auto {i + 1}: {autot[i]}");
            //}


            //Console.ReadLine();
            #endregion

            //5. Funktio ja luokat
            #region
            //Car auto1 = new Car("BMW", 2022);
            //Car auto2 = new Car("Jeep", 2000);

            //auto1.carsPresentation();
            //auto2.carsPresentation();

            //Console.ReadKey();
            #endregion





        }
    }
}
