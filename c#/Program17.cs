﻿//single dim array
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
            int[] arr = new int[5];//creating array  
            arr[0] = 10;//initializing array  
            arr[2] = 20;
            arr[4] = 30;

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }  
            Console.ReadLine();
        }
    }
}
