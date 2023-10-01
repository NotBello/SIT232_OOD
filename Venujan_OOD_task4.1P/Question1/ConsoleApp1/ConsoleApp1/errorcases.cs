using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handleError
{
    internal class errorcases
    {
        public void nullreferenceexception()
        {
            string str = null;
            int length = str.Length; // This line will throw a NullReferenceException

        }

        public void indexoutofrangeexception()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sixthElement = numbers[5]; // This line will throw an IndexOutOfRangeException
        }

        private static int RecursiveFunction(int n)
        {
            return RecursiveFunction(n + 1); // Recursive call without termination condition
        }

        public void stackoverflowexception()
        {
            
            // Call the recursive function
            int result = RecursiveFunction(1);

        }

        public void outofmemoryexception()
        {
            List<byte[]> listOfArrays = new List<byte[]>();

            while (true)
            {
                byte[] newArray = new byte[1000000]; // Allocating a large array
                listOfArrays.Add(newArray);
            }

        }

        public void invalidcastexception()
        {
            object myObject = "Hello";
            int myInt = (int)myObject; // This line will throw an InvalidCastException

        }

        public void dividebyzeroexception()
        {
            //int result = 10 / 0; // This line will throw a DivideByZeroException

        }

        public void Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.", nameof(divisor));
            }
            int result = dividend / divisor;
        }

        public void argumentexception()
        {
            Divide(1,0);
        }

        public void argumentoutofrangeexception()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 10;
            int value = numbers[index]; // This line will throw an ArgumentOutOfRangeException
        }

        static void SimulateSystemError()
        {
            // Simulating a system-related error
            throw new SystemException("This is a simulated SystemException.");
        }

        public void systemexception()
        {
            try
            {
                SimulateSystemError();
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Caught a SystemException:");
                Console.WriteLine(ex.Message);
            }
        }


    }
}
