// If Condition
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

            int num;
            Console.Write("Enter num=");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            Console.WriteLine("Hello....");
            Console.ReadLine();




        }
    }
}
