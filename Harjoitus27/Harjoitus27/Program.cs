using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma joka tulostaa halutun määrän tähtiä esim. 3 tulos on ***

            //1. Pyydetään käyttäjältä numero ja tallennetaan se muuttujaan

            Console.Write("Syötä haluamasi tähtien määrä: ");
            int luku = int.Parse(Console.ReadLine());

            //2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran
            // Tulostetaan yksi tähti, toistetaan käyttäjän syöttämän numeron verran
            //while / do while //
            //for // kun tiedetään montako kertaa
            //foreach

            //Muokataan sovellus tulostamaan käyttäjän syöttämä merkki

            //jos number = 5 ja i = 1; 0, 1, 2, 3, 4, => suoritetaan 5 kertaa

            for (int i = 1; i <= luku; i++)            //muuttuja; ehto; iteraatio
            {
                Console.WriteLine("*");
            }

            







            Console.ReadKey();
        }
    }
}
