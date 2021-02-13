using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested-Classes-10
{
    class Program
    {
            public static double Sqrt(double a, int times)
            {
                if (a < 0)
                    throw new Exception("Nie można spierwiastkować liczby ujemnej");
                double x = 1;
                while (times-- > 0)
                    x = x / 2 + a / (2 * x);
                return x;
            }

        static void Main(string[] args)
        {
            double wynik = Sqrt(3,10);
            Console.WriteLine("10 prób dla 3 = " + wynik);
            double wynik2 = Sqrt(5, 111);
            Console.WriteLine("100 prób dla 5= " + wynik2);
            double wynik3 = Sqrt(37, 555);
            Console.WriteLine("555 prób dla 37 = " + wynik3);

            Console.ReadKey();
        }
    }
}
