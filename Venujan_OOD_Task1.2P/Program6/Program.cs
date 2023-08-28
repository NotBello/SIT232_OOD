using System;
using System.ComponentModel.DataAnnotations;

class GuessNymber
{
    static int InputValidation(bool Valid, int IntInput)
    {
        while (!Valid)
        {
            try
            {
                IntInput = Convert.ToInt32(Console.ReadLine());
                if ((IntInput >= 1) && (IntInput <= 10))
                {
                    Valid = true;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Try Again");
            }

        }

        return IntInput;
    }

    static void Main(string[] args)
    {
        int NumInput = 0;
        int CheckedNumInput = 0;
        bool Validate = false;
        bool InnerValidate = false;

        while (!InnerValidate)
        {
            Console.WriteLine("Enter an integer between 1 and 10");
            CheckedNumInput = InputValidation(Validate, NumInput);


        
            if (CheckedNumInput < 7)
            {
                Console.WriteLine("Try higher");
            }else if (CheckedNumInput > 7){
                Console.WriteLine("Try lower");
            }else
            {
                InnerValidate = true; 
                Console.WriteLine("Nice.Right on mark.");
            }
        }
        

    }
}