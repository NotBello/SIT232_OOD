// Created by Venujan Malaiyandi   (A.k.a Bello)
// BSCP|CS|61|101 
// For Helping Others Task 1.3D

using System;
using System.Net;

namespace NetwkUtility {
    public class DnsResolver
    {
        public static string ResolveToIP(string domain)
        {
            try
            {
                IPAddress[] addresses = Dns.GetHostAddresses(domain);

                if (addresses.Length > 0)
                {
                    return addresses[0].ToString();
                }
                else
                {
                    return "No IP addresses found for the specified domain.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
