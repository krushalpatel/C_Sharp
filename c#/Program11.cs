//nested If Condition
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

            int a = 100;
            int b = 200;

            /* check the boolean condition */
            if (a != 100)
            {

                /* if condition is true then check the following */
                if (b != 200)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
                else
                {
                    Console.WriteLine("value of b is not 200");
                }
            }
            else if (a == 50)
            {
                Console.WriteLine("value of a is not 100");
            }
            else
            {
                Console.WriteLine("value of a is 100");
            }
            Console.WriteLine("Exact value of a is : {0} and b is {1}", a,b);
          
            Console.ReadLine();




        }
    }
}
