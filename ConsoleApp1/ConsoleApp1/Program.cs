using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////BUILDIN A GUESSING GAME 1.
            #region
            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;


            //while(guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess:  ");
            //        guess = Console.ReadLine();
            //        guessCount++;

            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
            //}
            //if (outOfGuesses)
            //{
            //    Console.Write("You Lose!");

            //}
            //else
            //{
            //    Console.Write("You win!");
            //}
            #endregion

            //FOR LOOPS 2.
            #region

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };


            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);

            //}


            #endregion

            // BUILDING AN EXPONENT METHOD 3.
            #region

            //Console.WriteLine(GetPow(4, 3));

            //Console.ReadLine();
            #endregion

            // 2D ARRAYS 4.
            #region

            //int[,] numberGrind =
            //{
            //    {1, 2},
            //    {3, 4},
            //    {5, 5}
            //};
            //int[,] myArray = new int[2, 3];
            //Console.WriteLine(numberGrind[1, 1]);

            //Console.ReadKey();

            #endregion

            // COMMENTS 5.
            #region
            //This print somethin
            //Console.WriteLine("Comments are fun");

            //Console.ReadLine();

            #endregion

            // EXCEPTION HANDLING 6.
            #region
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{

            //}

            //Console.ReadKey();
            #endregion

            // CALSSES & OBJECTS 7.
            #region

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 800;



            Console.WriteLine(book1.pages);

            Console.ReadKey();
            #endregion
        }
        // Harj. 3
        #region
        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }

        //    return result;
        //}
        #endregion // 



    }
}
