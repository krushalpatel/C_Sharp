﻿//Arithmetic Operators


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
            int result;
            int x = 10, y = 5;

            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            Console.ReadLine();
        }
    }
}
