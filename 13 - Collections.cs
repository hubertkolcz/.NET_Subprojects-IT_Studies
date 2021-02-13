using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections-13
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            ArrayList list = new ArrayList();
            for (int i = 0; i < 20; i++) {
                 list.Add(random.Next(1, 51)); 
            }
            
            list.Sort();
            Console.Write(list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
