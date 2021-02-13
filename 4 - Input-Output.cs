using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Input-Output-4
{
    class Program
    {
        // Exercise 2
        class Rownanie
        {
            public double a, b, c, x1, x2, delta;
            public Rownanie(double a, double b, double c)
            {
                this.a = a; this.b = b; this.c = c;
            }

            public void Rozwiazanie(double a, double b, double c)
            {
                delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    Console.WriteLine("Równanie kwadratowe ({0})x^2+({1})x+({2}) = 0 - brak pierwiastków rzeczywistych", a, b, c);
                } else if(delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Równanie kwadratowe ({0})x^2+({1})x+({2}) = 0 posiada jeden pierwiastek podwójny: x1 = {3}", a, b, c, Math.Round(x1, 2));
                } else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie kwadratowe ({0})x^2+({1})x+({2}) = 0 posiada dwa pierwiastki: x1 = {3} oraz x2 = {4}", a, b, c, Math.Round(x1, 2), Math.Round(x2, 2));
                }
            }
        }

        static void Main(string[] args)
        {

            // Exercise 1
            List<char> message = new List<char>();
            int seed = 1;
            ConsoleKeyInfo letter = Console.ReadKey();

            while (letter.Key != ConsoleKey.Q && letter.Key != ConsoleKey.Escape)
            {
                if (letter.Key == ConsoleKey.Z)
                {
                    message.Add((char)((letter.Key - 26) + seed));
                } else
                {
                    message.Add((char)(letter.Key + seed));
                }
                letter = Console.ReadKey();
            }

            Console.WriteLine();

            foreach(char m in message)
            {
                Console.Write(m);
            }

            Console.WriteLine();
            Console.WriteLine();

            Rownanie rownanie1 = new Rownanie(2, 4, 2);
            Rownanie rownanie2 = new Rownanie(4, 8, 4);
            Rownanie rownanie3 = new Rownanie(4, 4, 4);
            rownanie1.Rozwiazanie(rownanie1.a, rownanie1.b, rownanie1.c);
            rownanie2.Rozwiazanie(rownanie1.a, rownanie2.b, rownanie2.c);
            rownanie3.Rozwiazanie(rownanie3.a, rownanie3.b, rownanie3.c);

            Console.WriteLine();

            // Exercise 3
            bool isErr;
            String text;
            List<int> numbers = new List<int>(); ;

            // display monit for user input until isErr = false, then process the data and return the contents of numbers, se and tmp lists.
            do
            {
                Console.Write("Podaj liczby po przecinku: ");
                text = Console.ReadLine();
                string[] result = Regex.Split(text, "[\\s,]");
                isErr = false;

                foreach (string candidate in result)
                {
                    if (!string.IsNullOrEmpty(candidate))
                    {
                        try
                        {
                            int i = int.Parse(candidate);
                            numbers.Add(i);
                        }
                        catch (System.FormatException)
                        {
                            isErr = true;
                            numbers.Clear();
                        }
                    }
                }
                if(isErr)
                {
                    Console.WriteLine("Podany ciąg musi zawierać wyłącznie cyfry. Spróbuj ponownie.\n");
                }
            } while (isErr);

            if(!isErr && numbers.Count > 0)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine("Numbers[{0}]: {1}", numbers.IndexOf(number), number);
                }

                List<int> tmp = new List<int>();
                List<int> se = new List<int>();

                foreach (int number in numbers)
                {
                    if (number == 3 || number == 2)
                    {
                        if (se.IndexOf(number) == -1)
                        {
                            se.Add(number);
                        }
                    }
                    else
                    {
                        if ((number % 2 == 0 || number % 3 == 0) && tmp.IndexOf(number) == -1 && se.IndexOf(number) == -1)
                        {
                            tmp.Add(number);
                        }
                        else
                        {
                            se.Add(number);
                        }
                    }

                }

                Console.WriteLine();

                Console.WriteLine("Zawartość tablicy początkowej:");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Elementy wykluczone:");
                foreach (int t in tmp)
                {
                    Console.Write(t + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Liczby pierwsze:");
                se.Sort();
                foreach (int s in se)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
