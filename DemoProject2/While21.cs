using System;
using System.Collections.Generic;
using System.Text;
// Find the largest digit in the given number.
namespace CSharpcodepractice
{
    internal class While21
    {
        internal static void largest()
        {
            Console.WriteLine("The number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            int check = 0;

            while(number > 0)
            {
                int num = number % 10;
                if(num > check)
                {
                    check = num;
                }
                number = number / 10;
            }
            Console.WriteLine("Largest digit is: " + check);
        }
    }
}
