/*
 * Written by Venujan Malaiyandi
 * BSCP | CS | 61 | 101
 * Bucket Sort for Accounts
*/

using System;
using System.Collections.Generic;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Test the AccountsSorter class for array
            Account[] accountsArray = new Account[]
            {
                new Account(1000000, "Venujan"),
                new Account(15000, "Saro"),
                new Account(600, "Dev"),
                new Account(20000, "David")
            };

            AccountsSorter.Sort(accountsArray, 4);

            Console.WriteLine("Test the AccountsSorter class for arra");
            Console.WriteLine("Sorted Accounts by Balance:");
            foreach (Account acc in accountsArray)
            {
                acc.Print();
            }

            Console.WriteLine();

            
            // Test the AccountsSorter class for list
            List<Account> accountsList = new List<Account>
            {
                new Account(1000000, "Venujan"),
                new Account(15000, "Saro"),
                new Account(6000, "Dev"),
                new Account(20000, "David")
            };

            AccountsSorter.Sort(accountsList, 4);

            Console.WriteLine("Test the AccountsSorter class for list");
            Console.WriteLine("Sorted Accounts by Balance:");
            foreach (Account acc in accountsList)
            {
                acc.Print();
            }

            // Test special cases
            List<Account> emptyList = new List<Account>();
            AccountsSorter.Sort(emptyList, 4); // Sorting an empty list should not cause any issues

            Account[] nullArray = null;
            AccountsSorter.Sort(nullArray, 4); // Sorting a null array should not cause any issues
        }
    }
}
