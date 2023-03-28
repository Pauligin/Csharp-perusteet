using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uusi aihe: Ohjausrakenne - Control structure
            // 1. if - rakenne

            // if(ehto - condition) // Lopputulos true / false
            // {  <- start of if code block
            //if condition == true
            //suoritetaan if blokin koodi
            // } <- end of if code block
            // jos condition == false
            // Hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if( 50 > 10) //true
            {
                Console.WriteLine("Sisällä if");
            }
            Console.WriteLine("Jälkeen if");

            //2- if - else
            //Joko suoritetaan if code block
            //Tai suoritetaan else code block

            Console.WriteLine("before if-else");
            if ("Moi" != "Terve")
            {
                Console.WriteLine("Inside if");
            }
            else
            {
                Console.WriteLine("Inside else");
            }
            Console.WriteLine("after if-else");




            //3. if - else if - else

            //rakenteessa voi olla myös muita vertailuja
            //ainoastaan yks code block suoritetaan
            //Vaikka useampi kohta olisi oikein

            if (6.5 >= 5.5 ) //isompi tai samanarvoinen
            {
                Console.WriteLine("Inside if");
            }
            else if (10 <= 20) //pienempi tai samanarvoinen
            {
                Console.WriteLine("Inside else-if");
            }
            else
            {
                Console.WriteLine("Inside else");
            }

            //Vertailuoperaattorit - Comparison operators
            //Vertailujen lopputulos on totuusarvo - boolean
            // true/false


            // == samat arvot
            // != erisuuret
            // < vasen pienempi kuin oikea
            // > oikea isompi kuin oikea
            // <= Vasen pienempi tai yhtä suuri kuin oikea
            // => Vasen isompi tai yhtä suuri kuin oikea


            //Loogiset operaattorit - Logical operators
            //Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta -and-
            // age >= ageLimit && length == targetHeigth

            // || toinen totta -or-  ctrl+alt+<
            // age >= ageLimit || length == targetHeigth

            // ! kääntää totuusarvon
            // bool accountDeleted = true;
            //if(!accountDeleted)
            //{
            //Jos EI ole poistettu. voidaan käyttää
            //}


            //if sulkujen sisällä pitää olla true
            //Jos vertaillaan arvoa, jonka halutaan olla false
            // ! ennen muuttujaa

            // 4. Silmukat - Loops

            //while(condition)
            // {
            //      Execute done
            //      As long as condition == true
            // }

            //ensin kaalataan koodia
            //kommentointi ctrl + k sitten ctrl + c
            //poisto ctrl + k sitten ctrl + u
            // while (true)
            //
            //{
            //  Console.Write("Moi");
            // }

            string input = "";
            while(input != "exit")
            {
                Console.Write("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }

            //Pysäytetään sovellus.
            Console.ReadKey();
            Console.WriteLine("Press any key to end.");

           



        }
    }
}
