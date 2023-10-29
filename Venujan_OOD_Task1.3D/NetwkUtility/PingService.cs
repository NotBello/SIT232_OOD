// Created by Venujan Malaiyandi   (A.k.a Bello)
// BSCP|CS|61|101 
// For Helping Others Task 1.3D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace NetwkUtility
{
    public class PingService
    {
        // Properties
        public string Address { get; set; }
        public int Data { get; set; }
        public byte[] Buffer { get; set; }
        public int Timeout { get; set; }
        public PingOptions pingOptions { get; set; }

        // Constructor
        public PingService()
        {
            Timeout = 120;
            Address = "4.2.2.2";
            Buffer = Encoding.ASCII.GetBytes("I like programming");
            pingOptions = new PingOptions();
            pingOptions.DontFragment = true;
        }

        // Method to send a ping
        public bool SendPing(out PingReply reply)
        {
            Ping pingSender = new Ping();
            reply = pingSender.Send(Address, Timeout, Buffer, pingOptions);
            return reply.Status == IPStatus.Success;
        }

        // Method to set the address dynamically
        public void SetAddress(string address)
        {
            Address = address;
        }
    }
}
