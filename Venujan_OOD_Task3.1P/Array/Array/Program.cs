﻿using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1st question step 1

            // declares an array of type double with 10 elements
            double[] myArray = new double[10];

            // assigning the first element of the array
            myArray[0] = 1.0;

            // assigning the second element of the array
            myArray[1] = 1.1;

            // assigning the third element of the array
            myArray[2] = 1.2;

            // assigning the fourth element of the array
            myArray[3] = 1.3;

            // assigning the fifth element of the array
            myArray[4] = 1.4;

            // assigning the sixth element of the array
            myArray[5] = 1.5;

            // assigning the seventh element of the array
            myArray[6] = 1.6;

            // assigning the eighth element of the array
            myArray[7] = 1.7;

            // assigning the ninth element of the array
            myArray[8] = 1.8;

            // assigning the tenth element of the array
            myArray[9] = 1.9;

            // 1st question step 2

            // print the elements of the array
            Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
            Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
            Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
            Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
            Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
            Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
            Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
            Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
            Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
            Console.WriteLine("The element at index 9 in the array is " + myArray[9]);




            Console.WriteLine("");





            // 2nd question step 1

            int[] myIntArray = new int[10];

            // poplate the array
            for (int i = 0;i < myIntArray.Length; i++)
            {
                myArray[i] = i;
            }            

            // 2nd question step 2

            // print the elements of the array
            for (int j = 0;  j < myIntArray.Length; j++)
            {
                Console.WriteLine("The element at the position " + j + " in the array is " + myArray[j]);
            }





            Console.WriteLine("");





            // 3rd question step 1
            int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            for (int k = 0; k < studentArray.Length; k++)
            {
                Console.WriteLine("The element at the position " + k + " in the array is " + studentArray[k]);
            }

            for (int k = 0;  k < studentArray.Length; k++)
            {
                total += studentArray[k]; 
            }

            // 3rd question step 2
            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consists of " + studentArray.Length + " marks.");
            Console.WriteLine("Thus the average mark is " + (total / studentArray.Length));




            Console.WriteLine("");

            // 4th question step 1

            string[] studentNameArray = new string[6];
            for (int l = 0;  l < studentNameArray.Length; l++)
            {
                Console.WriteLine("Enter student name : ");
                studentNameArray[l] = Console.ReadLine();
            }
            
            // 4th question step 2
            for (int l = 0; l < studentNameArray.Length; l++  )
            {
                Console.WriteLine("The name of the student in position " + l + " is " + studentNameArray[l]);
            }

            

            Console.WriteLine("");

            // 5th question step 1
            double[] compareArray = new double[10];
            int currenSize = 0;
            double currentLargest, currentSmallest;

            for (int m = 0; m < compareArray.Length; m++)
            {
                Console.WriteLine("Enter double num : ");
                compareArray[m] = Convert.ToDouble(Console.ReadLine());
            }

            for (int m = 0; m < compareArray.Length; m++)
            {
                Console.WriteLine("The number in position " + m + " is " + compareArray[m]);
            }

            // 5th question step 2
            currentLargest = compareArray[0];
            currentSmallest = compareArray[0];
            for (int m = 0;m < compareArray.Length; m++)
            {
                if (compareArray[m] > currentLargest)
                {
                    currentLargest = compareArray[m];
                }
                if (compareArray[m] < currentSmallest)
                {
                    currentSmallest = compareArray[m];
                }
            }

            Console.WriteLine("\nThe largest number in the array is " +  currentLargest);
            Console.WriteLine("\nThe smallest number in the array is " + currentSmallest);

            */

            // 6th question step 1
            int[,] myArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2} };



        }
    }
}