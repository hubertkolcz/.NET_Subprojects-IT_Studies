using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract-Classes-8
{
    // Exercise 1
    public abstract class First
    {
        public abstract void F(int x);
        public abstract void R();
    }

    public class Second : First
    {
        public override void F(int x)
        {
            Console.WriteLine("rozkład na czynniki: ");

            for (int i = 2; x>1;i++)
                if(x%i == 0)
                {
                     x = x / i;
                     Console.WriteLine(i);
                     i = i - 1;
                }    
        }  
	
        public override void R()
        {
            String S1;
            String S2 = "";
            int i;
            int c = 1;

            Console.WriteLine("Run Length Encoder");

            S1 = "Unnniiiiwwerrrsyyyttttteeeeet Gddddaansssskkii";

            for (i = 0; i < S1.Length - 1; i++)
            {
                if (S1[i] == S1[i + 1])
                {
                    c++;
                }
                else
                {

                    S2 += S1[i];
                    S2 += c;
                    c = 1;
                }
            }
            Console.WriteLine("Wynik Unnniiiiwwerrrsyyyttttteeeeet Gddddaansssskkii" + "\n" + S2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe do rozkładu na czynniki pierwsze");
            int x = Convert.ToInt32(Console.ReadLine());

            Second second = new Second();
            second.F(x);
            second.R();
            Console.ReadLine();
        }
    }
}
