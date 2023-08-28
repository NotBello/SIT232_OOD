using System;

namespace DivisibleFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers between 1 and {n} that are evenly divisible by four but not by five:");

            for (int i = 1; i <= n; i++)
            {
                if ((i % 4 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
