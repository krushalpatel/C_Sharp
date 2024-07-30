//variables


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
            Console.Write("Enter string....=");

            string a;
            a = Console.ReadLine();
            Console.WriteLine("Value of String=" + a);
            Console.WriteLine();

            Console.Write("Enter int....=");


            int b;
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value of int=" + b);
            Console.WriteLine();

            Console.Write("Enter float....=");

            float c;
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Value of float="+c);
            Console.WriteLine();

            Console.Write("Enter double....=");

            double d;
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value of double=" + d);
            Console.WriteLine();

            Console.Write("Enter char....=");

            char e;
            e=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Value of char="+e);
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
