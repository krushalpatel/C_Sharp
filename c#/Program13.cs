//for loop with break and continue
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int a = 10; a < 20; a = a + 1)
            {
                
                if (a == 13)
                {
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                if (a == 15)
                {
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
