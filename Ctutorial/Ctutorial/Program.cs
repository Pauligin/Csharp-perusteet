using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //DRAWING A SHAPE

            //Console.WriteLine("   /|");
            //Console.WriteLine("  / |");
            //Console.WriteLine(" /  |");
            //Console.WriteLine("/___|");

            //Console.ReadLine();


            //VARIABLES = muuttujat

            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 25;

            //Console.WriteLine("There once was a man named " + characterName );
            //Console.WriteLine("He was " + characterAge + " years old");

            //characterName = "Mike";
            //Console.WriteLine("He really likes the name " + characterName );
            //Console.WriteLine("But didn't like being " + characterAge);

            //Console.ReadLine();


            //DATA TYPES

            //string phrase = "Giraffe Academy";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.2;
            //bool isMale = true;

            //Console.WriteLine(true);

            //Console.ReadLine();


            //WORKING WITH STRING

            //string phrase = "Giraffe Academy";
            //Console.WriteLine (phrase.Substring(phrase.IndexOf("Academy")) );

            //// \n = jakaa toiselle riville
            ////phrase.toLower()
            ////phrase.toUpper()
            ////phrase.Contains("Academy") True/False
            ////phrase[0] = first
            ////phrase.IndexOf('f') = 4 
            ////phrase.Substring(8, 3) = Aca

            //Console.ReadLine();


            //WORKING WITH NUMBERS

            ////int num = 40;
            ////num++; = +1
            ////num--; = -1
            ////Math.Abs() = -40 -> 40
            ////Math.Pow() = Potenssilasku
            ////Math.Sqrt() = neliöjuuren laskeminen
            ////Math.Max() = Valitsee isomman
            ////Math.Min() = -||- pienemmän
            ////Math.Round() = Pyöristää luvun lähimpään kokonaislukuun

            //Console.WriteLine( Math. );

            //Console.ReadLine();


            //GETTING USER INPUT

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("hello " + name + " you are " + age + " years old ");

            //Console.ReadLine();


            //BUILDING A CALCULATOR

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            //Console.ReadLine();


            //BUILDING A MAD LIBS GAME

            string color, pluralNoun, celebratity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebratity: ");
            celebratity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue ");
            Console.WriteLine("I love " + celebratity);

            Console.ReadLine();
        }
    }
}
