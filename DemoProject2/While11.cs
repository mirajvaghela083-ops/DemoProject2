using System;
using System.Collections.Generic;
using System.Text;
// Check whether the given number is a prime number.
namespace DemoProject2
{
    internal class While11
    {
       internal static void primeCheck()
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("Not a prime number");
                return;
            }
               int i = 2; // divisor 
                bool isPrime = true ;

                while(i <= number / 2 )
                {
                    if ( number %i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                    Console.WriteLine($"{number} is a prime number");
                else
                    Console.WriteLine($"{number} is not a prime number");
            


        }
    }
}
