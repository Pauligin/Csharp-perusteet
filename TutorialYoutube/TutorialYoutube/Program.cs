using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialYoutube
{
    class Program
    {
        static void Main(string[] args)
        {

            ////ARRAYS 1.

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            //string[] friends = new string[5];

            //friends[0] = "Jim";
            //friends[1] = "kelly";

            //Console.WriteLine( luckyNumbers[1] );

            //--------------------------------------------------//

            ////METHODS 2.

            //SayHi("Mike", 34);
            //SayHi("john", 53);
            //SayHi("Tom", 66);

            //--------------------------------------------------//


            //// RETURN STATEMENT 3.

            //double cubedNumber = cube(5);

            //Console.WriteLine(cubedNumber);

            //--------------------------------------------------//

            //// IF STATEMENTS 4.

            //bool isMale = false;
            //bool isTall = false;

            //if (isMale && isTall) //  || = or // && = and
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You not a male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male or not tall");

            //}

            //--------------------------------------------------//

            //// MORE IF STATEMENTS 5.

            //Console.WriteLine(GetMax(20, 10, 40));

            //--------------------------------------------------//

            ////BUILDING A BETTER CALCULATOR 6.

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.Write(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.Write(num1 - num2);

            //}
            //else if (op == "/")
            //{
            //    Console.Write(num1 / num2);

            //}
            //else if (op == "*")
            //{
            //    Console.Write(num1 * num2);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            //--------------------------------------------------//

            //// SWITCH STATEMENTS 7.

            //Console.WriteLine(GetDay(40));



            //--------------------------------------------------//

            //WHILE LOOPS 8.

            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);


            Console.ReadKey();

        }

        //static void SayHi(string name, int age)   2. Harj.
        //{
        //    Console.WriteLine("Hello " + name + " You are " + age + " yers old");
        //}

        //--------------------------------------------------//

        //static double cube(double num) 3. Harj.
        //{
        //    double result = num * num * num;
        //    return result;
        //}

        //--------------------------------------------------//

        //static int GetMax(int num1, int num2, int num3) //  5. Harj.
        //{
        //    int result;

        //    if (num1 != num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;

        //}

        //--------------------------------------------------//

        //static string GetDay(int dayNum) // 7. Harj.
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid day Number";
        //            break;
        //    }
        //    return dayName;
        //}

    }
}
