using System;

namespace NumtoWordWithValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool InputValidation = false;
            int number = 0;

            while (!InputValidation)
            {
                Console.WriteLine("Enter a number between 1 and 9:");
                string input = Console.ReadLine();

                try
                {
                    number = Convert.ToInt32(input);
                    if (number >= 1 && number <= 9)
                    {
                        InputValidation = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 9.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.\nEnter a valid number.");
                }
            }

            string word = NumtoStrConvert(number);
            Console.WriteLine($"The word representation of {number} is {word}.");
            Console.WriteLine("Program End");
        }

        static string NumtoStrConvert(int number)
        {
            if (number == 1)
            {
                return "ONE";
            }
            else if (number == 2)
            {
                return "TWO";
            }
            else if (number == 3)
            {
                return "THREE";
            }
            else if (number == 4)
            {
                return "FOUR";
            }
            else if (number == 5)
            {
                return "FIVE";
            }
            else if (number == 6)
            {
                return "SIX";
            }
            else if (number == 7)
            {
                return "SEVEN";
            }
            else if (number == 8)
            {
                return "EIGHT";
            }
            else if (number == 9)
            {
                return "NINE";
            }
            else
            {
                return null;
            }
        }
    }
}
