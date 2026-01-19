using System;
using System.Collections.Generic;
using System.Text;
// Print the cube of each number from 1 to n .
namespace DemoProject2
{
    internal class While15
    {
        internal static void square()
        {
            Console.WriteLine(" The Number Is :");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= n)
            {
                int cube = i * i * i;
                Console.WriteLine(cube);
                i++;
            }

        }
    }
}
