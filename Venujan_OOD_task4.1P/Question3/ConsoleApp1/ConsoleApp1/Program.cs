using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    public class errorcases
    {
        public void nullreferenceexception()
        {
            string str = null;

            // This line will throw a NullReferenceException
            try
            {
                int length = str.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException:");
                Console.WriteLine(ex.Message);
            }
        }

        public void indexoutofrangeexception()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // This line will throw an IndexOutOfRangeException
            try
            {
                int sixthElement = numbers[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException:");
                Console.WriteLine(ex.Message);
            }
        }

        private static int RecursiveFunction(int n)
        {
            return RecursiveFunction(n + 1); // Recursive call without termination condition
        }

        public void stackoverflowexception()
        {
            // This line will throw a StackOverflowException
            try
            {
                int result = RecursiveFunction(1);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("Caught a StackOverflowException:");
                Console.WriteLine(ex.Message);
            }
        }

        public void outofmemoryexception()
        {
            List<byte[]> listOfArrays = new List<byte[]>();

            try
            {
                while (true)
                {
                    byte[] newArray = new byte[1000000]; // Allocating a large array
                    listOfArrays.Add(newArray);
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Caught an OutOfMemoryException:");
                Console.WriteLine(ex.Message);
            }
        }

        public void invalidcastexception()
        {
            object myObject = "Hello";

            // This line will throw an InvalidCastException
            try
            {
                int myInt = (int)myObject;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Caught an InvalidCastException:");
                Console.WriteLine(ex.Message);
            }
        }

        public void dividebyzeroexception()
        {
            int a = 0;

            // This line will throw a DivideByZeroException
            try
            {
                int result = 10 / a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught a DivideByZeroException:");
                Console.WriteLine(ex.Message);
            }
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
            try
            {
                Divide(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Caught an ArgumentException:");
                Console.WriteLine(ex.Message);
            }
        }

        public void argumentoutofrangeexception()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 10;

            // This line will throw an ArgumentOutOfRangeException
            try
            {
                int value = numbers[index];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught an ArgumentOutOfRangeException:");
                Console.WriteLine(ex.Message);
            }
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

    internal class Program
    {
        static void Main(string[] args)
        {
            errorcases usrOne = new errorcases();

            List<Action> methodList = new List<Action>();

            methodList.Add(usrOne.nullreferenceexception);
            methodList.Add(usrOne.indexoutofrangeexception);
            methodList.Add(usrOne.outofmemoryexception);
            methodList.Add(usrOne.invalidcastexception);
            methodList.Add(usrOne.dividebyzeroexception);
            methodList.Add(usrOne.argumentexception);
            methodList.Add(usrOne.argumentoutofrangeexception);
            methodList.Add(usrOne.systemexception);
            methodList.Add(usrOne.stackoverflowexception);

            foreach (Action action in methodList)
            {
                Console.WriteLine();
                try
                {
                    action();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("The following error detected: " +
                    exception.GetType().ToString() + " with message \"" +
                    exception.Message + "\"");
                }
            }
        }
    }


}
