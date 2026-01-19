using System;
using System.Collections.Generic;
using System.Text;
// Find and print the sum of the Fibonacci series up to n terms.
namespace DemoProject2
{
    internal class While13
    {
            internal static void sumOfFibonacci()
        {
            Console.WriteLine("The term you want :");
            int n = Convert.ToInt32(Console.ReadLine());

            long first = 0;
            long second = 1;
            int count = 0;
            long sum = 0;                         

            while (count < n )
            {
                long next = first + second;
                first = second;
                second = next;

                sum += first;

                
                count++;

            }
            Console.WriteLine(sum + " ");
        }
    }
}
