using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp34D
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tee ohjelma, jossa käyttäjältä kysytään 2 merkkijonoa.
            //Ohjelma laskee kuinka monta kertaa ensimmäisen merkkijonon kirjaimia on toisessa merkkijonossa
            //Tallennetaan merkit ja niiden lukumäärät 2d taulukkoon.Käytä merkissä sen int arvoa.
            //Esim jos merkkijonot ovat "kuppi" ja "kauppa" ohjelma tulostaa

            //k 1 kerta

            //u 1 kerta

            //p 2 kertaa

            //Extra osa

            //Lisää ohjelmaan toiminto joka tulostaa ne merkit, jotka ovat merkkijonossa 1, mutta ei merkkijonossa 2.

            Console.Write("Syötä sana 1: ");
            string word1 = Console.ReadLine(); // "kuppi"

            Console.Write("Syötä sana 2: ");
            string word2 = Console.ReadLine(); // "kauppa"

            //Taulukon käytön ongelmat:
            //1. Ei voi tietää kuinka pitkä sana on 
            //2. Ei voi tietää montako merkkiä ovat samoja

            // TODO: Luo taulukkon pituus tarkalleen oikein.

            //charsIncommon sisältää merkit, jotka ilmenevät molemmissa sanoissa ja montako kertaa ne ilmenee
            //tässä datatyyppi on "Tuple" johon voi tallentaa kaksi eri datatyyppiä yhdessä
            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            string charsTested = "";

            //Luodaan silmukka, joka käy läpi kaikki word1 merkit ja tarkistetaan ilmeneekö se word2-muuttujassa

            for (int i = 0; i < word1.Length; i++) // word1 indeksi == i
            {
                int numberOftimesFound = 0;

                for (int j = 0; j < word2.Length; j++) // word2 indeksi == j
                {
                    //Onko sanan 1 indeksissä i sama kirjain kuin sanan 2 indeksissä j
                    //Ja ei ole vielä tallennettu kirjainta taulukkoon

                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false)
                    {
                        // Estetään saman kirjaimen tallennus uudestaan

                        numberOftimesFound++;
                        charsInCommon[i] = (word1[i], numberOftimesFound);
                    }
                }
                
                //Lisätään löydetty merkki, vasta sisemmän silmukan jälkeen.
                charsTested += word1[i];

            }

            //Silmukka, jossa käydään läpi taulukko löydetyistä kirjaimista
            foreach ((char, int) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
