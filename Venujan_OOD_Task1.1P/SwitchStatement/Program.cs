using System;

namespace NumtoWordWithValidationWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool InputValidate = false;
            int number = 0;

            while (!InputValidate)
            {
                Console.WriteLine("Enter a number between 1 and 9:");
                string input = Console.ReadLine();

                try
                {
                    number = Convert.ToInt32(input);
                    if (number >= 1 && number <= 9)
                    {
                        InputValidate = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a number between 1 and 9.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                }
            }

            string word = ConvIntToWord(number);
            Console.WriteLine($"The word representation of {number} is {word}.");
        }

        static string ConvIntToWord(int number)
        {
            switch (number)
            {
                case 1:
                    return "ONE";
                case 2:
                    return "TWO";
                case 3:
                    return "THREE";
                case 4:
                    return "FOUR";
                case 5:
                    return "FIVE";
                case 6:
                    return "SIX";
                case 7:
                    return "SEVEN";
                case 8:
                    return "EIGHT";
                case 9:
                    return "NINE";
                default:
                    return null; // Return null for invalid numbers
            }
        }
    }
}
