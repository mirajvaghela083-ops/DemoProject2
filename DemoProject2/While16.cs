using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
// Print all numbers between a and b that are divisible by 7.
namespace DemoProject2
{
    internal class While16
    {
        internal static void div()
        {
            Console.WriteLine(" The number a is :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" The number b is : ");
            int b =Convert.ToInt32(Console.ReadLine());

          

           while ( a <= b )
            {
                if( a % 7 == 0 )
                {
                    Console.WriteLine(a);
                }
                a++;
               
            }
        }
    }
}
