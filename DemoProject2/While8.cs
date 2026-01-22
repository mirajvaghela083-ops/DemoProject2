// check whether the given number is an armstrong number .
namespace DemoProject2
{
    internal class While8
    {
        internal static void armStrong()
        {
            Console.WriteLine(" The Number Is : ");
            double number = Convert.ToDouble(Console.ReadLine());

            double orignal = number;

            double temp = number;

            double count = 0;

            double sum = 0;

            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }
            temp = number;

            while (temp > 0)
            {
                double digit = temp % 10;
                sum += Math.Pow(number, count);
                temp = temp / 10;
            }
            if (sum == orignal)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("it is not");
            }
        }
    }
}
