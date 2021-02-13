using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Constructor-Overloading-2
{
    class Program
    {
    // Exercise 1
        class Testowa
        {
            public double liczba;
            public char znak;

            public Testowa(double liczba)
            {
                this.liczba = liczba;
            }

            public Testowa(char znak)
            {
                this.znak = znak;
            }

            public Testowa(double liczba, char znak)
            {
                this.liczba = liczba;
                this.znak = znak;
            }

            public Testowa(double a, double b)
            {
                Console.WriteLine("Podana liczba A: " + a);
                Console.WriteLine("Podana liczba B: " + b);

                while(a != b)
                {
                    if(a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                Console.WriteLine("NWD liczb A i B: " + a);
                Console.WriteLine();
            }

            public Testowa(int[] tab)
            {
                List<int> tmp = new List<int>();
                List<int> se = new List<int>();

                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = i + 2;
                }

                se.Add(tab[0]);
                se.Add(tab[1]);

                for (int i = 2; i < tab.Length; i++)
                {
                    if (tab[i] % 2 == 0 || tab[i] % 3 == 0)
                    {
                        if (tmp.IndexOf(tab[i]) == -1)
                        {
                            tmp.Add(tab[i]);
                        }
                    }
                }

                int k = 3;
                int value;

                while (k < tab.Length)
                {
                    if (tmp.IndexOf(tab[k]) == -1)
                    {
                        value = tab[k];
                        for (int i = k; i < tab.Length; i++)
                        {
                            if (tmp.IndexOf(tab[i]) == -1)
                            {
                                if (tab[i] % value == 0 && tab[i] != value)
                                {
                                    tmp.Add(tab[i]);
                                }
                                else
                                {
                                    if (se.IndexOf(tab[i]) == -1)
                                    {
                                        se.Add(tab[i]);
                                    }
                                }
                            }
                        }
                    }
                    k++;
                }

                Console.WriteLine("Zawartość tablicy początkowej:");
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write(tab[i] + " ");
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
                foreach (int s in se)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
	// Exercise 2
        class Kwadrat
        {
            public int bok, pole, sk_x, sk_y, lgr_x, lgr_y, pdr_x, pdr_y;

            public Kwadrat(int lgr_x, int lgr_y, int pdr_x, int pdr_y)
            {
                this.lgr_x = lgr_x;
                this.lgr_y = lgr_y;
                this.pdr_x = pdr_x;
                this.pdr_y = pdr_y;
            }

            public Kwadrat(int ops, int v1, int v2, int v3)
            {
                bool shouldContinue = true;
                while(shouldContinue)
                {
                    switch (ops)
                    {
                        case 0: shouldContinue = false;
                            Console.WriteLine("Kończenie pracy programu...");
                            break;
                        case 1:
                            this.lgr_x = v1;
                            this.lgr_y = v2;
                            this.bok = v3;
                            break;
                        case 2:
                            this.sk_x = v1;
                            this.sk_y = v2;
                            this.bok = v3;
                            break;
                        case 3:
                            this.sk_x = v1;
                            this.sk_y = v2;
                            this.pole = v3;
                            break;
                        default:
                            Console.WriteLine("Wprowadzono niepoprawny numer operacji. Spróbuj ponownie.");
                            break;
                    }
                }
            }
        }
        // Exercise 3
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 2;
            }

            Testowa t1 = new Testowa(4);
            Testowa t2 = new Testowa('a');
            Testowa t3 = new Testowa(7, 'b');

            Console.WriteLine("t1 - liczba: " + t1.liczba);
            Console.WriteLine("t2 - znak: " + t2.znak);
            Console.WriteLine("t3 - liczba i znak: " + t3.liczba + " " + t3.znak);
            Console.WriteLine("t4 - NWD:");
            Testowa t4 = new Testowa(12, 42);
            Console.WriteLine("t5 - Sito Erastotenesa:");
            Testowa t5 = new Testowa(tab);
        }
    }
}
