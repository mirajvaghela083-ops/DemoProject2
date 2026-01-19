using System;
using System.Collections.Generic;
using System.Text;
// Print all prime numbers between 1 and 100.
namespace DemoProject2
{
    internal class While10
    {
        internal static void prime()
        {
            int num = 2;

            while (num <= 100)
            {
                int i = 2;
                bool isPrime = true;
                while (i <= num / 2)
                {
                    if (num % i  == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                {
                    Console.WriteLine(num);
                }
                num++;
            }

        }
    }
}
