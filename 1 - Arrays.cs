using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Arrays-1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            for (int i = 100; i >= 1; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            int j = 100;
            while (j >= 1)
            {
                if (j % 3 == 0 && j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j--;
            }
            Console.WriteLine();

            int k = 100;
            do
            {
                if (k % 3 == 0 && k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
                k--;
            } while (k >= 1);
            Console.WriteLine();

            // Exercise 2

            int[][] tab = new int[4][];
            int width = 1;
            for (int x = 0; x < tab.Length; x++)
            {
                tab[x] = new int[width];
                width++;
            }
            int value = 10;
            for (int m = 0; m < tab.Length; m++)
            {
                for (int n = 0; n < tab[m].Length; n++)
                {
                    tab[m][n] = value;
                    value--;
                    if (m == 0)
                    {
                        Console.Write(tab[m][n]);
                    }
                    else
                    {
                        Console.Write(tab[m][n] + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Exercise 3

            int[][] fib = new int[10][];
            int[] tmp = new int[10];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    tmp[i] = 1;
                }
                else
                {
                    tmp[i] = tmp[i - 2] + tmp[i - 1];
                }
            }

            int depth;
            for (int i = 0; i < fib.Length; i++)
            {
                Console.Write("tab[{0}]: ", i);
                fib[i] = new int[tmp[i]];

                depth = 0;

                for (int r = tmp[i]; r > 0; r--)
                {
                    fib[i][depth] = r;
                    Console.Write(fib[i][depth] + " ");
                    depth++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
