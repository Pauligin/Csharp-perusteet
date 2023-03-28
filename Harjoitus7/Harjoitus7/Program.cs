using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolmion ala lasketaan kaavasta A=ah/2 missä a on kanta ja h on korkeus.
            //Laadi ohjelma, joka saa syöttötietoina kannan ja korkeuden la laskee kolmion pinta-alan.


            //ilmoitetaan käyttäjälle, mitä tietoa pyydetään
            Console.WriteLine("Anna kolmion kanta: ");
            //luetaan käyttäjältä arvo string muodossa
            //ja muokataan string -> double muotoon

            double triangleBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolmon korkeus: ");
            double triangleHeigth = double.Parse(Console.ReadLine());

            //Voidaan näyttää laskutoimituksen lopputulos suoraan osana tekstiä. Huomioi "Magic number" -2-
            Console.WriteLine($" Kolmion pinta-ala on: {triangleBase * triangleHeigth / 2}");


            //Pysäytetään sovellus
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
