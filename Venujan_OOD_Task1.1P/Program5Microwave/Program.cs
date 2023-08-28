using System;

namespace MicrowaveOven
{
    class Microwave
    {
        static void Main(string[] args)
        {
            bool InputValidation = false;

            Console.WriteLine("Microwave Calculator");

            while (!InputValidation)
            {


                Console.Write("Enter number of items: ");
                int ItemNum = Convert.ToInt32(Console.ReadLine());


                if (ItemNum <= 0)
                {
                    Console.WriteLine("Invalid input. Number of items must be greater than 0.");
                }
                else
                {
                    Console.Write("Enter the single-item heating time (in seconds): ");
                    double singleItemTime = Convert.ToDouble(Console.ReadLine());

                    if (singleItemTime <= 0)
                    {
                        Console.WriteLine("Invalid input. Heating time must be greater than 0.");

                    }
                    else
                    {
                        double recommendedTime = CalculateRecommendedTime(ItemNum, singleItemTime);
                        if (recommendedTime == -1)
                        {
                            Console.WriteLine("Not Recommended. Retry");
                        }
                        else {
                            Console.WriteLine($"Recommended heating time: {recommendedTime} seconds");
                            InputValidation = true;
                        }
                        
                    }
                }
            }
        }

        static double CalculateRecommendedTime(int numberOfItems, double singleItemTime)
        {
            if (numberOfItems == 2)
            {
                return singleItemTime * 1.5; // Add 50%
            }
            else if (numberOfItems == 3)
            {
                return singleItemTime * 2; // Double the time
            }
            else
            {
                Console.WriteLine("Heating more than three items is not recommended.");
                return -1; // Return a sentinel value to indicate an invalid recommendation
            }
        }
    }
}
