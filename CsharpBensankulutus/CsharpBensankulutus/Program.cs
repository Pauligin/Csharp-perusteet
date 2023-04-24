using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Luo metodi, joka ottaa parametreinä ajetun matkan, ajoneuvon keskikulutuksen ja polttoaineen litrahinnan.
            //Metodi palauttaa ajoneuvolla ajetun matkan polttoaineen hinnan euroina.

            //2.Pyydä Main - funktiossa käyttäjältä tarvittavat tiedot ja tallenna ne muuttujiin.

            //3.Käytä metodia käyttäjän syöttämillä arvoilla ja tallenna metodin tulos muuttujaan.

            //4.Näytä käyttäjälle metodin lopputulos.

            //5.Lisää Main - funktioon silmukka, joka toistaa sovellusta, kunnes käyttäjä päättää lopettaa.

            //6.Lisää sovellukseen taulukko ja lista, joihin tallennetaan jokaisella silmukan kierroksella metodin palauttama arvo.
            //(taulukon käytössä on yksi ongelma, joka ratkaistaan extra osassa)

            //7.Kun käyttäjä lopettaa matkojen syöttämisen, tulostetaan käyttäjälle kaikkien matkojen hinnat taulukosta ja listasta.

            //Extra: Lisää uusi metodi, joka ottaa parametrinä taulukon ja palauttaa uuden taulukon, joka on yhtä indeksiä pidempi.
            //Uudessa taulukossa on myös vanhan taulukon arvot.Lisää tämän metodin käyttäminen kohtaan 6, kun taulukkoon ei enää mahdu uutta arvoa.


            bool userEndsLoop = false;

            //List<(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal)>();// Tuple
            // 0, 1, 2, 3, 4,5 

            List<decimal> userDistance = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä.


            decimal[] test = new decimal[1];
            (decimal, decimal, decimal)[] trips = new (decimal, decimal, decimal)[1];


            // Kohta 5, lisätään koko koodi silmukkaan

            while (userEndsLoop == false)        //While, kun ei tiedetä
            {
                Console.Write("Syötä ajettu matka(km): ");
                decimal distance = decimal.Parse(Console.ReadLine());
                userDistance.Add(distance);

                Console.Write("Syötä ajoneuvon keskikulutus(l/100km): ");
                decimal averageConsumption = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumption);


                Console.Write("Syötä polttoaineen hinta (e/l): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(fuelPrice);

                trips[trips.Length - 1] = (distance, averageConsumption, fuelPrice);


                //decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

                //Console.WriteLine();    //Tyhjä rivi.
                //Console.WriteLine($"Ajetun matkan hinta on: {tripCost} euroa. ");
                //Console.WriteLine();    //Tyhjä rivi.

                Console.Write("Calculate another trip? (y/n): ");
                string input = Console.ReadLine();

                if (input == "n") // Käyttäjä lopettaa sovelluksen
                {
                    userEndsLoop = true; // Kun tämä muuttuja on true, silmukka päättyy
                }
                else //laajennetaan taulukko
                {
                    //test = expandArray(test);
                    //test = expandArray(test);
                    trips = expandArray(trips); // expandArray palauttaa uuden taulukon, joka on yhtä suurempi
                                                // kuin alkuperäinen taulukko, joka annetaan parametrinä.
                }

            }

            // Käydään lista läpi ja tulostetaan matkojen hinnat.
            for (int i = 0; i < userDistance.Count; i++)
            {
                Console.WriteLine($"Matkan {i + 1} hinta on: {carTripCostCalculator(userDistance[i], userAverageConsumption[i], userFuelPrice[i])}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


        // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.
        private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsumption, decimal fuelCost)
        {
            decimal result = 0;

            result = distanceInKilometers * averageConsumption * fuelCost / 100;

            return result;
        }

        private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
        {
            //Luodaan uusi taulukko, joka on yhtä suurempi kuin alkuperäinen taulukko
            (decimal, decimal, decimal)[] newArray = new (decimal, decimal, decimal)[originalArray.Length + 1];

            //Kopioidaan arvot vanhasta taulukosta uuteen taulukkoo
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            return newArray;
        }



    }
}
