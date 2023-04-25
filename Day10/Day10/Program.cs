using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisää sovellukseen Luokat "Square" ja "Triangle".

            //Määritä niille tarvittavat propertit.

            //Lisää metodit niiden pinta-alan ja ympärysmitta.

            //Testataan luokkia Main - funktiossa.

            Square squareOne = new Square(5, 10);
            Console.WriteLine($"Area on square one is: {squareOne.Area()}");
            Console.WriteLine($"Circumference of square one is: {squareOne.Circumference()}");

            Square squareTwo = new Square(1, 2);

            Triangle triangleOne = new Triangle(2, 5);
            Console.WriteLine($"Area of the triangle one is: {triangleOne.Area()}");
            Console.WriteLine($"Perimeter of the triangle one is: {triangleOne.Perimeter()}");



            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");

            Console.ReadKey();


        }


    }// Program päättyy
    
    public class Square
    {
        //Properties
        public double Width { get; set; }
        public double Heigth { get; set; }

        //Constructors
        public Square(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        //Methods

        public double Area()// Huomioikaa, ei tarvitse parametrejä, Voi tosin olla parametrejä tarvittaessa.
        {
            return Width * Heigth; // Arvot löytyvät suoraan ovjektista.
        }

        public double Circumference()
        {
            return (Width * 2) + (Heigth * 2);
        }
    }

}