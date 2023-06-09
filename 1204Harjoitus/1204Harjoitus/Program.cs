﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1204Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            //32B Luetaan käyttäjältä lukuja.
            //Tallennetaan luvut taulukkoon talteen. Lopuksi summataan taulukossa olevat arvot.
            //Toteuta sama asia, mutta käyttämällä listaa.


                        //tilaa 3:lle 
            int[] userValues = new int[3];

            //Silmukka, jossa pyydetään 3 arvoa. 1 per kierros.
            //Silmukan ehto on se, että päätetään suoritus silloin,
            //kun i-muuttujan arvo on taulukon indeksien ulkopuolelle
            //Jos pituus on 3, indeksit ovat 0 1 2

            Console.WriteLine("Syötä 3 lukua: ");


            for (int i = 0; i < userValues.Length; i++)
            {
                userValues[i] = int.Parse(Console.ReadLine());
            }

            // Myöhemmi tarvitaan summa

            Console.WriteLine($"Lukujen summa on: {userValues.Sum()}");

            int sum = 0;

            //Silmukka, jossa summataan kaikkien indeksien arvot.
            //Voi olla myös foreach


            //for = kun tiedetään luvut
            for (int i = 0; i < userValues.Length; i++)
            {
                sum = sum + userValues[i];
            }

            Console.WriteLine($"Lukujen summa on: {sum}");


            //Lista versio
            //Tässä versiossa käyttäjä voi tallentaa niin monta lukua kuin haluaa.

            Console.WriteLine("Syötä lukuja: ");
            List<int> values = new List<int>();
            bool userIsDone = false;


            //Silmukka, jossa käyttäjä voi syöttää haluamansa verran lukuja.
            while (userIsDone == false)  // tai do while
            {
                string userInput = Console.ReadLine();

                if (userInput == "e")
                {
                    userIsDone = true;
                }
                else // Muuten lisätään luku listaan.
                {
                    values.Add(int.Parse(userInput));
                }
            }

            //Listan summaus
            Console.WriteLine($"Listan lukujen summa on: {values.Sum()}");

            int sumList = 0;

            foreach (int number in values)
            {
                sumList += number;
            }

            Console.WriteLine($"Listan lukujen summa on: {sumList}");

            Console.ReadKey();

        }
    }
}
