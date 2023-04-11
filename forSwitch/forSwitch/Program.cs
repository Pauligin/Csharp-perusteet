using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 12d;

            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        initialValue += i;
                        break;
                    case 2:
                        initialValue *= i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue -= i;
                        break;
                }
            }

            Console.WriteLine("Arvo on: " + initialValue);

            Console.ReadKey();
        }
    }
}
