//Unboxing
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
            // assigned int value
            // 23 to num
            int num = 23;

            // boxing
            object obj = num;

            // unboxing
            int i = (int)obj;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
            Console.ReadLine();
        }
    }
}
