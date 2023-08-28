using System;

namespace RepetitionStatement
{
    class Repetition
    {
        static void Main(string[] args)
        {
            bool InputValidation = false;
            int number = 0;
            double sum = 0;
            double average = 0;

            while (!InputValidation)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();

                try
                {
                    number = Convert.ToInt32(input);

                    InputValidation = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.\nEnter a valid number.");
                }
            }

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Convert.ToString(i));
                sum += i;
            }

            string StrSum = sum.ToString();

            average = sum / number;

            string StrAvg = average.ToString();

            Console.WriteLine($"The sum is {StrSum}");
            Console.WriteLine($"The average is {StrAvg}");



            Console.WriteLine("Program End");
        }


    }
}

