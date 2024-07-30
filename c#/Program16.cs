//for each loop
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

            Console.WriteLine("Print array:");

            
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
