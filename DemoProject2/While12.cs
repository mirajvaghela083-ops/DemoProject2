using System;
using System.Collections.Generic;
using System.Text;
//  Print the Fibonacci series up to n terms.
namespace DemoProject2
{
    internal class While12
    {
        internal static void Fibonacci()
        {
            Console.WriteLine("the terms you want :");
            int n = Convert.ToInt32(Console.ReadLine());
            long first = 0;
            long second = 1;
            long count = 0;

            while (count < n)
            {
             long  next = first + second;
                first = second;
                second = next;

                Console.WriteLine(first + "");
                count++;
            }
        }
    }
}
