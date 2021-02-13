using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces-9
{
    interface Interfejs
    {
        int x
        {
            get;
            set;
        }
        int y
        {
            get;
            set;
        }
    }

    class Dziedziczy : Interfejs{
        private int wspX, wspY;
        public int x
        {
            get
            {
                return wspX;
            }
            set
            {
                wspX = value;
            }
        }
        public int y
        {
            get
            {
                return wspY;
            }
            set
            {
                wspY = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dziedziczy dziedziczy = new Dziedziczy();

            dziedziczy.x = 15;
            dziedziczy.y = 5;
            Console.WriteLine("x = {0}", dziedziczy.x);
            Console.WriteLine("x = {0}", dziedziczy.y);

            while (dziedziczy.x != dziedziczy.y)
            {

                if (dziedziczy.x > dziedziczy.y)
                    dziedziczy.x = dziedziczy.x - dziedziczy.y;
                else
                    dziedziczy.y = dziedziczy.y - dziedziczy.x;
            }

            int nd = dziedziczy.x;

            int nw = Math.Abs(dziedziczy.x * dziedziczy.y) / nd;
            Console.WriteLine("Wynik nww:" + nw);

            Console.ReadKey();
        }
    }
}
