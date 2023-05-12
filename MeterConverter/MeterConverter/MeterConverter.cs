
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterConverter
{
    class MeterConverter
    {


        //Constructors

        //Methods
        public static double ToCentimeter(double meters)
        {
            return meters * 100;
        }

        public static double ToKilometer(double meters)
        {
            return meters / 100;
        }

        public static double ToDecimetre(double meters)
        {
            return meters * 10;
        }
        public static double ToInch(double meters)
        {
            return meters * 39.37;
        }
        public static double ToFoot(double meters)
        {
            return meters * 3.281;
        }
        public static double ToYard(double meters)
        {
           return meters * 1.094;
              
        }




        // Loput metodit

    }
}
