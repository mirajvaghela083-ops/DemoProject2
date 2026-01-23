// Print all factors of the given number.
namespace DemoProject2
{
    internal class While17
    {
        internal static void factor()
        {
            Console.WriteLine("The Number Is : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive number only.");
                return;
            }

            int x = 1;
           // int sum = 0;

            while (x <= num)
            {
                if (num % x == 0)
                {
                    // sum = sum + x;
                    Console.WriteLine(x);
                }

                x++;

            }
            //Console.WriteLine(sum);
        }
    }
}
