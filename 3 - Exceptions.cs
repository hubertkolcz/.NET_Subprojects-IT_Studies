using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions-3
{
    class Program
    {
        public Program(int[] tab)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 9 ; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int x = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = x;
                    }
                }
            }
            for (int y = 0; y < 10; y++)
                Console.WriteLine(tab[y]);
        }

        static void Main(string[] args)
        {
            // Exercise 1
            
            try
            {
                int a = 10, b = 0, wynik;
                wynik = a / b;
            }
            catch(SystemException e)
            {
                Console.WriteLine("Wystąpił wyjątek systemowy:");
                Console.WriteLine(e);
            }
            Console.ReadKey();


            // Exercise 2

            int[] tablica = new int[10];

            Console.WriteLine("Podaj 10 liczb całkowitych");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    tablica[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Program program = new Program(tablica);

            Console.ReadKey();
        }
    }
}
