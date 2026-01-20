using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
// Find the smallest digit in the given number.
namespace CSharpcodepractice
{
    internal class While20
    {
        internal static void smallest()
        {
            Console.WriteLine("The number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            int check = 9;
            while (number > 0)
            {
                int num = number % 10;
                if (num < check)
                {
                    check = num;
            }
                number = number / 10;
           
       
            }
            Console.WriteLine("Smallest digit is: " + check);

        }

    }
}
