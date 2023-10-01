using System;

namespace handleError
{
    class Program
    {
        
        static void Main(string[] args)
        {
            errorcases usrOne = new errorcases();

            Console.WriteLine("The options:");
            Console.WriteLine("Press 0 for NullReferenceException");
            Console.WriteLine("Press 1 for IndexOutOfRangeException");
            Console.WriteLine("Press 2 for StackOverflowException");
            Console.WriteLine("Press 3 for OutOfMemoryException");
            Console.WriteLine("Press 4 for InvalidCastException");
            Console.WriteLine("Press 5 for DivideByZeroException");
            Console.WriteLine("Press 6 for ArgumentException");
            Console.WriteLine("Press 7 for ArgumentOutOfRangeException");
            Console.WriteLine("Press 8 for SystemException");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    usrOne.nullreferenceexception();
                    break;
                case 1:
                    usrOne.indexoutofrangeexception();
                    break;
                case 2:
                    usrOne.stackoverflowexception();
                    break;
                case 3:
                    usrOne.outofmemoryexception();
                    break;
                case 4:
                    usrOne.invalidcastexception();
                    break;
                case 5:
                    usrOne.dividebyzeroexception();
                    break;
                case 6:
                    usrOne.argumentexception();
                    break;
                case 7:
                    usrOne.argumentoutofrangeexception();
                    break;
                case 8:
                    usrOne.systemexception();
                    break;
            }
        }
    }
}