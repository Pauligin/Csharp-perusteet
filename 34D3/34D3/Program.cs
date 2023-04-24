using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D3
{
    class Program
    {
        static void Main(string[] args)
        {

            //34D3 C# String: Merkit taulukkoon ja listaan


            Console.Write("Syötä sana: ");

            string sana = Console.ReadLine();

            char[] sanaMerkkeina = sana.ToCharArray();

            List<char> sanaLista = new List<char>(sanaMerkkeina);

            Console.Write("Sana taulukossa: ");
            foreach (char c in sanaMerkkeina)
            {
                if (c % 2 != 0)
                {
                    Console.Write((char)(c - 32));
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();

            Console.Write("Sana listassa: ");
            foreach (char c in sanaLista)
            {
                if (c % 2 == 0)
                {
                    Console.Write((char)(c - 32));
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.ReadKey();

        }
    }
}
