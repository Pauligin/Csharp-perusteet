using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aloitetaan tekemällä sovellus, joka tulostaa lukuja 1 - käyttäjän syöttämä luku

            //1.Pyydetään käyttäjältä luku
            //2.Luetaan ja tallennetaan luku muuttujaan

            Console.Write("Anna luku, johon asti tulostetaan: ");
            int luku = int.Parse(Console.ReadLine());

            //3.Luodaan silmukka, joka suoritetaan niin monta kertaa kuin 1 - käyttäjä luku on
            //      -while, pitää miettiä jokin sopiva ehto
            //      - jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muuttuja, joka on alussa 1

            int i = 1; // iterointi: i++ => 1++ => i == 3 jne

            //Kysytään käyttäjältä halutaanko parillinen vai pariton
            Console.Write("Parillinen / Pariton: ");
            string input = Console.ReadLine();

            while (i <= luku)
            {
                //Lisätään ehto, joka tulostaa vain parittoman numeron
                if (i % 2 != 0 && input == "Pariton")
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 0 && input == "Parillinen")
                {
                    Console.WriteLine(i);
                }
                i++; // Suoritetaan iteraatio jokaisella silmukan kierroksella
            }


            ////4.Silmukassa tulostetaan numero 1, jonka muuttuja interoidaan joka kierros

            //string EVEN_TEXT = "Parillinen";
            //string ODD_TEXT = "Pariton";




            //Console.Write("Anna luku, johon asti tulostetaan: ");
            //int luku = int.Parse(Console.ReadLine());


            ////While tarkistaa, että käytäjä syöttää hyväksyttävän arvon

            //string input = ""; // Muuttuja luodaan ennen silmukkaa, jottai sitä voi käyttää ehdossa.
            //bool inputFalse = true;

            //while (inputFalse == true)//Silmukka toistetaan, niin kauan kuin käyttäjän input on väärin
            //{
            //    Console.Write($"{ EVEN_TEXT} / { ODD_TEXT}: ");
            //    input = Console.ReadLine();

            //    if (input == EVEN_TEXT)
            //    {
            //        inputFalse = false; // Kun tämä muuttuja on false, pysähtyy silmukka
            //    }
            //    else if (input == ODD_TEXT)
            //    {
            //        inputFalse = false; // Kun tämä muuttuja on false, pysähtyy silmukka
            //    }
            //}



            //// Käyttäjän syöte tarkistetaan aiemmin
            //int startingPoint = input == EVEN_TEXT ? 2 : 1;


            ////Parillinen alkaa 2
            ////Pariton alkaa 1

            //for (int i = startingPoint; i <= luku; i += 2) //pienempi tai yhtäsuuri <=
            //{
            //    Console.WriteLine();
            //}

            Console.ReadKey();


        }
    }
}
