using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj._34
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            string[] splitInput = new string[1]; //Placeholder taulukko
            bool inputHasErrors = true;

            while (inputHasErrors == true)
            {
                Console.Write("Syötä sana ja poistettavien merkkien määrä(\"Omena\" 1); ");
                input = Console.ReadLine();

                splitInput = input.Split(' ');
                // Tällä taulukolla on indeksit 0 ja 1

                // Muokataan "inputHasErrors"- totuusmuuttujan arvo false, jos käyttäjän syöte on OK.
                // Tällöin silmukka päättyy.
                // TODO: error checking and place Readline inside a loop until passes error checking
                // [Luku > 0 ] JA [ luku * 2 < sana.Length ]

                // splitInput[0] == käyttäjän syöttämä sana
                // splitInput[1] == käyttäjän syöttämä numero
                // 0 == vähintään poistettavien merkkien määrä
                // 2 == lasketaan yhteensä poistettavien merkkien määrä kertomalla poistettavat merkit kahdella
                //      alusta ja lopusta == kertaa 2
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1]) * 2 < splitInput[0].Length)
                {
                    inputHasErrors = false;
                }

            }



            // Vaihtoehto 1
            // Otetaan käyttäjän sanasta Substring
            // Substring vaatii aloitus indeksin ja montako merkkiä otetaan talteen aloituskohdasta lähtien.

            //               0123456 <-- string arvon indeksit
            // Esimerkiksi: "testaus" 2
            // Tarvittavat arvot Substring-metodiin alla:
            // Nämä indeksit on itse sen string merkkijonon indeksejä.
            // Aloitusindeksi: 2
            // Tallennettavien merkkien määrä: 3 => sanan pituus - alun poisto - lopun poisto = merkkien määrä
            //                                  splitInput [0].Length - poistettavat merkit * 2 = merkkien määrä

            // UUSI TERMI: parametri, on metodin sulkujen sisöllä syötetyt arvot.
            //              overload, metodi voi ottaa vastaan eri määrän parametrejä. Overload ilmaisee montako vaihtoehtoa on.
            //              Hiiri metodin päällä: ctrl+K sitten ctrl+P, voi käydä läpi kaikki eri overload vaihtoehdot.

            string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            Console.WriteLine(result1);

            // Vaihtoehto 1


            // Vaihtoehto 2
            // Tehdään silmukka, jossa tallennetaan merkkejä yksi kerrallaan
            // "testaus 2" Aloitetaan silmukka kolmannesta merkistä ja jatketaan viimeiseen kopioitavaan indeksiin.
            // => "sta" 

            string result2 = ""; // Tähän lisätään merkkejä yksi kerrallaan
            //StringBuilder => jos suorituskyky ongelmia

            // Silmukka alkaa ensimmäisen tallennettavan merkin indeksistä ja loppuu viimeiseen tallennettavaan indeksiin.
            for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)
            {
                result2 += splitInput[0][i]; // Kopioidaan merkki käyttäjän sanan tietystä indeksistä.
                // splitInput[0] Viittaa käyttäjän sanaan eli => "testaus"[i]
            }
            Console.WriteLine(result2);



            // Vaihtoehto 2




            Console.ReadKey();
        }
    }
}
