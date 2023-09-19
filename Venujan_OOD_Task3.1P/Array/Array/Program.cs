using System;
using System.Security.Cryptography.X509Certificates;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

            

            // 6th question
            int[,] myArray2 = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2} };
             for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Console.WriteLine(myArray2[i, j] + "\t");
                }
                Console.WriteLine();
            }


            // 7th question step 1
            List<string> myStudentList = new List<string>();

            Random randomVaue = new Random();
            int randomNumber = randomVaue.Next(1, 12);

            // 7th question step 2
            Console.WriteLine("You need to add " + randomNumber + " students to your class list");
            for (int i = 0; i < randomNumber; i++)
            {
                Console.WriteLine("Please enter the name of the student " + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();

            }

            Console.WriteLine("The list size is : " +  myStudentList.Count);

            for (int j = 0; j < myStudentList.Count; j++)
            {
                Console.WriteLine(myStudentList[j]);
            }
            
            Console.WriteLine("");

            // 8th question
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int result1 = FuncOne(arr1);
            Console.WriteLine("Result 1: " + result1); // Output: 8 (number of odd elements)

            int[] arr2 = { 2, 4, 6, 8, 10 };
            int result2 = FuncOne(arr2);
            Console.WriteLine("Result 2: " + result2); // Output: 3840 (product of even elements)

            
            
            Console.WriteLine("");

            // 9th question
            List<double> numbers = new List<double> { 10.0, 20.0, 30.0, 40.0, 50.0 };

            Console.WriteLine("Original List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            FuncTwo(numbers);

            Console.WriteLine("\nList After Subtracting Average:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        
            
            // 10th question
            int[,] inputArray = {
            {3, 6, 9},
            {2, 5, 8},
            {1, 4, 12}
        };

            int[] resultArray = FuncThree(inputArray);

            Console.WriteLine("Resulting one-dimensional array:");
            foreach (int num in resultArray)
            {
                Console.Write(num + " ");
            }
            
            
            // 11 question
            int[] arr = { 1, 4, 9 };
            int[,] multiplicationTable = FuncFour(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(multiplicationTable[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        // 8th question
        static int FuncOne(int[] intputArray) // since static is used, there is no need for obj ref
        {
            if (intputArray.Length > 10)
            {
                int oddCount = 0;
                foreach (var item in intputArray)
                {
                    if (Convert.ToInt32(item) % 2 != 0)
                    {
                        oddCount++;
                    }
                }
                return oddCount;
            }
            else
            {
                int product = 1;
                foreach (var item in intputArray)
                {
                    if (Convert.ToInt32(item) % 2 == 0)
                    {
                        product *= Convert.ToInt32(item);
                    }
                }
                return product;
            }
        }

        // 9th question
        static void FuncTwo(List<double> inputDoubleArray)
        {
            
            double sum = inputDoubleArray.Sum();
            double average = sum / inputDoubleArray.Count;

            for (int i = 0; i < inputDoubleArray.Count; i++)
            {
                inputDoubleArray[i] -= average;
            }
        }

        // 10th question
        static int[] FuncThree(int[,] inputArray)
        {
            int numRows = inputArray.GetLength(0);
            int numCols = inputArray.GetLength(1);
            int[] resultArray = new int[numRows * numCols];

            int index = 0;

            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    if (inputArray[row, col] % 3 == 0)
                    {
                        resultArray[index++] = inputArray[row, col];
                    }
                }
            }

            int[] resizedArray = new int[index]; // resizing array 
            for (int i = 0; i < index; i++)
            {
                resizedArray[i] = resultArray[i];
            }

            return resizedArray;
        }

        //11 question
        static int[,] FuncFour(int[] inputMulArray)
        {
            int[,] result = new int[inputMulArray.Length, inputMulArray.Length];

            for (int i = 0; i < inputMulArray.Length; i++)
            {
                for (int j = 0; j < inputMulArray.Length; j++)
                {
                    result[i, j] = inputMulArray[i] * inputMulArray[j];
                }
            }

            return result;
        }

    }
}