using System;
using System.IO;

namespace Operations-on-System-Files-6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.Write("Podaj wartość parametru g: ");
            Int64 g = Int64.Parse(Console.ReadLine());
            
            int v = 0;
            double x, y, pi = 0;
            Random r = new Random();

            for(int i = 0; i <= g; i++)
            {
                x = r.NextDouble();
                y = r.NextDouble();

                if(x * x + y * y <= 1)
                {
                    v++;
                }

                pi = 4 * (float)v / i;
                if (i % 100 == 0)
                {
                    Console.WriteLine("Po {0} liczbach losowych liczba PI wynosi {1:#.#######}.", i, pi);
                }
            }

            Console.WriteLine();

            // create or overwrite existing monte_carlo.txt file
            if (File.Exists("monte_carlo.txt"))
            {
                Console.WriteLine("Plik monte_carlo.txt pomyślnie nadpisano");
            } else
            {
                Console.WriteLine("Plik monte_carlo.txt pomyślnie utworzono");
            }

            FileStream fs = new FileStream("monte_carlo.txt", FileMode.Create);
            fs.Dispose();

            Console.WriteLine();

            StreamWriter sw = new StreamWriter("monte_carlo.txt");

            try {
                // crop the output variable to 7th decimal place
                sw.WriteLine(String.Format("{0:#.#######}", pi));
                Console.WriteLine("Liczba PI została pomyślnie zapisana w pliku monte_carlo.txt");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                sw.Dispose();
            }
        }
    }
}
