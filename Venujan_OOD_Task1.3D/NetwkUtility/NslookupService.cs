// Created by Venujan Malaiyandi   (A.k.a Bello)
// BSCP|CS|61|101 
// For Helping Others Task 1.3D

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace NetwkUtility
{
    internal class NslookupService
    {
        public static string PerformNslookup(string domain)
        {
            try
            {
                Process nslookupProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "nslookup",
                        Arguments = domain,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                nslookupProcess.Start();
                string output = nslookupProcess.StandardOutput.ReadToEnd();
                nslookupProcess.WaitForExit();

                return output;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
