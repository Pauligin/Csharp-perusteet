using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1804Harjoitukset
{
    class Program // Luokka
    {
        static void Main(string[] args) // Funktio / Metodi
        {
            //    // 1. Funktio / Function
            //    // Funktio on keino kapsuloida tietty toiminnallisuus, jotai voidaan käyttää uudelleen
            //    // Eri kohdissa projektia.


            //    // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti.
            //    // Metodi on termi funktiolle, joka on osana luokkaa.

            //    // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen fuonktioon / metodiin
            //    // "Main" 

            //    // Funktion / Metodi tulee tiettyyn kohtaa tiedostoa.

            //    // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle
            //    // metodien / funktioiden kanssa, luokan sisälle

            //    // Tänne ei voi luoda uutta funktiota, koska olemme jo "Main"- funktion sisällä.
            //    // Metodi luotiin "Main". funktion alapuolelle

            //    // Täällä voidaan käyttää metodia

            //    // UUSI TERMI: olio / object
            //    // olio on instanssi luokasta.
            //    // oletuksena metodeja voi ainoastaan käyttää, kun luokasta on luotu objekti.
            //    // Nyt uutta "printText()" -metodia ei voida käyttää, ellei luoda luokasta "Program" uutta objektia.


            //    Program test = new Program(); // Luodaan tämän tiedoston "Program" luokasta objecti
            //    test.printText("Hello", 123);
            //    test.printText("World", 321);

            //    // Poikkeuksena staattinen metodi
            //    // Jos metodista luodaan staattinen, sitä voi käyttää suoraan ilman objektia.

            //    // Esim:
            //    Console.WriteLine(""); // Tämän on "Console" -luokan staattinen "WriteLine()"-metodi
            //    //Program.multiplyNumbers(2, 10); /// Viittaus "Program" luokkaan ei ole pakollinen,
            //    //koska olemme sen luokan sisällä.
            //    // Metodi palauttaa arvon, se pitää ottaa talteen.
            //    int fiveTimesThree = multiplyNumbers(5, 3);
            //    // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa
            //    // Nyt metodin "multiplyNumbers()" palautetta arvo toimii parametrinä metodille "WriteLine".
            //    Console.WriteLine(multiplyNumbers(5, 3));


            //    // 2. Luokka / Class


            //    // 2a
            //    // 2b
            //    // 2c
            //    // 2d


            //    // 3. Struct



            //    //4. enum


            //    Console.Write("Press any key to exit...");
            //    Console.ReadKey();


            //}// Main funktion

            //// Luodaan uusi metodi, muiden metodien ulkopuolelle, mutta luokan sisälle.

            //// [Näkyvyys] [palautettavaDatatyyppi] [metodinNimi] ( [parametrit], pilkulla eroteltuna)
            //// Tämä funktio ottaa vastaan kaksi arvoa: string message ja int number
            //// Metodi kirjoittaa consoliin parametrien sisällön

            //private void printText( string message, int number)
            //{
            //    // Private näkyvyys tarkoittaa, etttä sitä ei voida käyttää luokan ulkopuolelta 
            //    // Void -datatyyppi, ei palauta mitään
            //    // parametrit -dataa, joka lähetetään funktioon.
            //    Console.WriteLine($"Text: {message}{number} ");

            //}

            //// Luodaan staattinen metodi
            //// avainsana "Static" tulee näkyvyyden ja palautettavan datatyypin väliin.
            //// Tämä metodi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen

            //public static int multiplyNumbers ( int number1, int number2)
            //{
            //    // Public -näkyy luokan ulkopuolelle
            //    // static -tekee metodista staattisen (Voi käyttää ilman objektia)
            //    // int - tämä metodi palauttaa int-arvon

            //    return number1*number2; // Return avainsanalla palautetaan arvo.
            //}

            //Tee ohjelma joka laskee työntekijän palkan kun syöttötietoina annetaan tuntipalkka,
            //normaalipalkkaiset tunnit, 50% korotetut tunnit ja 100% korotetut tunnit.

            //Asetetaan Muuttujat 
            //Tallennetaan käyttäjän arvot

            ////Tuntipalkka
            //double hourlySalary;

            ////Tunnit, joista maksetaan 100% palkka
            //double normalHours;

            ////Tunnit, joista maksetaan 150% palkka 
            //double plus50PercentHours;

            ////Tunnit, joistamaksetaan 200% Palkka
            //double plus100PercentHours;

            ////Laskettu kuukausipalkka
            //double totalSalary;


            //Console.Write("Anna tuntipalkka:");
            //hourlySalary = double.Parse(Console.ReadLine());


            //Console.Write("Anna normaalit tunnit: ");
            ////Käyttäjän arvon lukeminen ilman -input- muuttujan käyttöä
            //normalHours = double.Parse(Console.ReadLine()); //Parse. Muuttaa tietotyypin

            //Console.Write("Anna 50% korotetut tunnit: ");
            //plus50PercentHours = double.Parse(Console.ReadLine());

            //Console.Write("Anna 100% korotetut tunnit: ");
            //plus100PercentHours = double.Parse(Console.ReadLine());

            ////Laskuoperaatio
            ////Laskukaavasta arvot 1.5 ja 2 käytetään termiä "Magic number"
            ////Laskuoperaation voi jakaa usealle riville
            ////Ratkaisu olisi tallentaa arvot sopivan nimisiin muuttujiin.
            ////Erityisesti jos arvoa käytetään useaan kertaan.

            //totalSalary = hourlySalary * normalHours + hourlySalary * 1.5 * plus50PercentHours + hourlySalary * 2 * plus100PercentHours;

            //Console.WriteLine($"Kuukausi palkka on {totalSalary}");

            //Console.Write("Anna kanta: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.Write("Anna korkeus: ");
            //double h = double.Parse(Console.ReadLine());


            //double A = a * h / 2;
            //Console.WriteLine($"Kolmion pinta-ala on {A}");

            //Console.WriteLine("Anna luku: ");
            //int luku = int.Parse(Console.ReadLine());

            //if (luku == 0)
            //{
            //    Console.WriteLine("Luku on 0.");
            //}
            //else if (luku > 0)
            //{
            //    Console.WriteLine("Luku on suurempi kuin 0.");
            //}
            //else
            //{
            //    Console.WriteLine("Luku on pienempi, kuin 0.");
            //}

            bool ageCorrect = false;

            while (!ageCorrect)
            {

                Console.Write("Anna ikä: "); //Write alkuun!

                //Luodaan muuttuja = int age

                int age = int.Parse(Console.ReadLine()); //Parsetetaan integer muotoon.
                int minAge = 0;
                int maxAge = 120;


                //Tarkistetaan, että ikä on sopiva. IF ehtojen jälkeen ei tarvis puolipistettä
                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Tallennus onnistui");
                }
                else
                {
                    Console.WriteLine("Arvo ei ole hyväksyttävällä välillä" + $" ({minAge}-{maxAge})");

                }


                Console.ReadKey();
            }
        }// Classs Program



    }//Namespace
}