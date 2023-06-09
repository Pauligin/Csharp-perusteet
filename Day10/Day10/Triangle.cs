﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Triangle
    {

        // Properties
        public double Heigth { get; set; }
        public double Base { get; set; }

        // Constructors
        public Triangle(double heigth, double baseParameter) 
        {
            Heigth = heigth;
            Base = baseParameter;
        }


        // Methods
        // EI tarvitse static, koska tätä käytetään luokan objektista.
        // Esim: Triangle test = new Triangle(2,5); - luodaan objekti luoksta, nimeltä "test"
        // Console.WriteLine(test.Area()); - käytetään objektin metodia.

        public double Area()
        {
            double result = 0;

            result = Base * Heigth / 2;

            return result;

        }

        public double Perimeter()
        {

            double result = 0;


            // hypotenuse = √(base² + heigth²)

             result = Heigth + Base + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Heigth, 2));


            return result;

        }

    }
}
