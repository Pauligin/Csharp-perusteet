using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> hinnatList = new List<double>();
            double[] hinnatArray = new double[5];
            int i = 0;

            while (true)
            {
                Console.WriteLine("Anna matkan pituus kilometreinä: ");
                double matka = double.Parse(Console.ReadLine());

                Console.WriteLine("Anna ajoneuvon polttoaineen kulutus litroina per 100 km: ");
                double kulutus = double.Parse(Console.ReadLine());

                Console.WriteLine("Anna polttoaineen hinta euroina per litra: ");
                double hinta = double.Parse(Console.ReadLine());

                double hintaYhteensa = LaskeKustannukset(matka, kulutus, hinta);
                Console.WriteLine("Ajetun matkan kustannukset ovat " + hintaYhteensa + " euroa.");

                hinnatList.Add(hintaYhteensa);
                hinnatArray[i] = hintaYhteensa;
                i++;

                if (i >= hinnatArray.Length)
                {
                    hinnatArray = LaajennaTaulukko(hinnatArray);
                }

                Console.WriteLine("Haluatko syöttää uuden matkan? (kyllä/ei)");
                string vastaus = Console.ReadLine().ToLower();

                if (vastaus == "ei")
                {
                    break;
                }
            }

            Console.WriteLine("Kaikkien syötettyjen matkojen kustannukset:");
            for (int j = 0; j < hinnatList.Count; j++)
            {
                Console.WriteLine("- " + hinnatList[j] + " euroa");
            }
            for (int j = 0; j < hinnatArray.Length; j++)
            {
                if (hinnatArray[j] != 0)
                {
                    Console.WriteLine("- " + hinnatArray[j] + " euroa");
                }
            }
        }

        static double LaskeKustannukset(double matka, double kulutus, double hinta)
        {
            double kulutusLitraa = matka / 100 * kulutus;
            double kustannukset = kulutusLitraa * hinta;
            return kustannukset;
        }

        static double[] LaajennaTaulukko(double[] taulukko)
        {
            double[] uusiTaulukko = new double[taulukko.Length + 1];
            Array.Copy(taulukko, uusiTaulukko, taulukko.Length);
            return uusiTaulukko;
        }
    }
}
    

