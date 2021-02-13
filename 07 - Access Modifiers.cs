using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access-Modifiers-7
{
    class Program
    {
        public static Boolean IsPalindrom(string wordToCheck)
        {
            if (String.IsNullOrEmpty(wordToCheck))
            {
                Console.WriteLine("Null lub pusta linia");
                return false;
            }
            wordToCheck = wordToCheck
                          .Replace(" ", "")
                          .ToLower();

            int length = wordToCheck.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (wordToCheck[i] != wordToCheck[length - i - 1])
                    return false;
            }
            return true;
        }

        static private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\NaszDom\Desktop\Studia V\Radomski - Programowanie .NET\9\palindromy.txt");

        static void Main(string[] args)
        {


            Console.WriteLine("Zawartośc pliku txt = ");
            Console.WriteLine();
            foreach (string line in lines)          
            {
                if (IsPalindrom(line) == true)
                    Console.WriteLine(" {0,-10:0} Jest palindromem", line);
                else
                    Console.WriteLine(" {0,-10:0} Nie jest palindromem", line);
            }

            Console.ReadKey();
        }
    }
}
