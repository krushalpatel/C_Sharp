//2D array
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
            int[,] arr = new int[3, 3]{{1,2,3},{4,5,6},{7,8,9}};//declaration of 2D array  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();//new line at each row  
            Console.ReadLine();
        }
    }
}
