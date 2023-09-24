using System;
using System.Collections.Generic;

namespace bank
{
    public static class AccountsSorter
    {
        public static void Sort(Account[] accounts, int b)
        {
            // Checking for empty set
            if (accounts == null || accounts.Length == 0)
            {
                return;
            }


            List<Account>[] buckets = new List<Account>[b];
            decimal M = GetMaximumBalance(accounts);

            for (int i = 0; i < b; i++)
            {
                buckets[i] = new List<Account>();
            }

            foreach (Account acc in accounts)
            {
                int index = (int)Math.Ceiling(b * (double)acc.Balance / (double)M) - 1; // Use Math.Ceiling and adjust index calculation
                buckets[index].Add(acc);
            }

            for (int i = 0; i < b; i++)
            {
                nextSort(buckets[i]);
            }

            int indexCount = 0;
            for (int i = 0; i < b; i++)
            {
                foreach (Account acc in buckets[i])
                {
                    accounts[indexCount] = acc;
                    indexCount++;
                }
            }
        }


        public static void Sort(List<Account> accounts, int b)
        {
            Account[] accountArray = accounts.ToArray();
            Sort(accountArray, b);
            accounts.Clear();
            accounts.AddRange(accountArray);
        }

        private static void nextSort(List<Account> bucket)
        {
            bucket.Sort((a, b) => a.Balance.CompareTo(b.Balance));
        }

        /*
         * 
         */
        private static decimal GetMaximumBalance(Account[] accounts)
        {
            decimal maxBalance = decimal.MinValue;
            foreach (Account acc in accounts)
            {
                if (acc.Balance > maxBalance)
                {
                    maxBalance = acc.Balance;
                }
            }
            return maxBalance;
        }
    }
}
