using System;

namespace DoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;

            int intAverage;
            intAverage = sum / count;

            Console.WriteLine($"Integer Average: {intAverage}"); 

            double doubleAverage;
            doubleAverage = sum / count;

            Console.WriteLine($"Double Average: {doubleAverage}. This is wrong");

            doubleAverage = (double)sum / count;

            Console.WriteLine($"Correct Double Average using casting: {doubleAverage}. This is right");
        }
    }
}
