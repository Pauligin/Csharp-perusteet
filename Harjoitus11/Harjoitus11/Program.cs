﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tee ohjelma, joka kysyy käyttäjältä luvun.
            //Ohjelma ilmoittaa onko luku 0 tai pienempi tai suurempi kuin 0

            //Pyydetään käyttäjältä luku
            Console.WriteLine("Anna luku: "); 
            int value = int.Parse(Console.ReadLine());
           
            if (value == 0 )
            {
                Console.WriteLine("Arvo on 0");
            }
            else if (value > 0)
            {
                Console.WriteLine("Arvo on suurempi kuin 0");
            }
            else
            {
                Console.WriteLine("Arvo on pienempi kuin 0");
            }

            Console.ReadKey();


        }
    }
}
