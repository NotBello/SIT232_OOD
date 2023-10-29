// Created by Venujan Malaiyandi   (A.k.a Bello)
// BSCP|CS|61|101 
// For Helping Others Task 1.3D

using System;
using System.Net.NetworkInformation;

namespace NetwkUtility {
    class Program
    {
        static void Main()
        {
            PingService pingService = new PingService();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Resolve domain to IP");
                Console.WriteLine("2. Ping an address");
                Console.WriteLine("3. Perform nslookup");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1, 2, 3, or 4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a domain to resolve: ");
                        string domain = Console.ReadLine();
                        string ipAddress = DnsResolver.ResolveToIP(domain);
                        Console.WriteLine("IP Address: " + ipAddress);
                        break;
                    case "2":
                        Console.Write("Enter an address to ping (press Enter for default): ");
                        string addressInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(addressInput))
                        {
                            pingService.SetAddress(addressInput);
                        }

                        PingReply reply;
                        bool success = pingService.SendPing(out reply);

                        if (success)
                        {
                            Console.WriteLine("Ping successful");
                            Console.WriteLine("Address: {0}", reply.Address.ToString());
                            Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);

                            if (reply.Options != null) // Add this check
                            {
                                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                            }
                            else
                            {
                                Console.WriteLine("Options not available for this reply.");
                            }

                            Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                        }
                        else
                        {
                            Console.WriteLine("Ping failed");
                        }
                        break;
                    case "3":
                        Console.Write("Enter a domain for nslookup: ");
                        string nslookupDomain = Console.ReadLine();
                        string nslookupResult = NslookupService.PerformNslookup(nslookupDomain);
                        Console.WriteLine(nslookupResult);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

