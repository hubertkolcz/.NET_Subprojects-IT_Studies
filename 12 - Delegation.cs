using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation-12
{
    class Pearson
    {
        public double Korelacja(double[] values1, double[] values2)
        {
            if (values1.Length != values2.Length)
                throw new ArgumentException("values must be the same length");

            var avg1 = values1.Average();
            var avg2 = values2.Average();

            var sum1 = values1.Zip(values2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = values1.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = values2.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

            return result;
        }
    }
    public class GenericList<T>
    {
        public void Add(T input) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> xx = new GenericList<double>();
            xx.Add(90);
            xx.Add(160);
            xx.Add(280);
            xx.Add(450);
            xx.Add(550);

            GenericList<double> yy = new GenericList<double>();
            xx.Add(1);
            xx.Add(2);
            xx.Add(3);
            xx.Add(4);
            xx.Add(50);

            double[] x = { 90, 160, 280, 450, 550 };
            double[] y = {1, 2, 3, 4, 5};
            Pearson pearson = new Pearson();
            Console.WriteLine(pearson.Korelacja(x, y);

            Console.ReadKey();
        }
    }
}
