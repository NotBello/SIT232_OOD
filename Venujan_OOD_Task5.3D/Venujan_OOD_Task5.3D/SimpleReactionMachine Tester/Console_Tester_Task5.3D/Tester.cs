//Created by Venujan Malaiyandi (A.k.a) Bello
// BSCP|CS|61|101
// For Task 5.3D
//Tester

using System;

namespace SimpleReactionMachine
{
    class Tester
    {
        private static IController controller;
        private static IGui gui;
        private static string displayText;
        private static int randomNumber;
        private static int passed = 0;

        static void Main(string[] args)
        {
            // run simple test
            SimpleTest();
            Console.WriteLine("\n=============================\nSummary: {0} tests passed out of 38", passed);
            Console.ReadKey(); // To make sure the program doen't end  
        }

        private static void SimpleTest()
        {
            controller = new SimpleReactionController();
            gui = new DummyGui();

            gui.Connect(controller);
            controller.Connect(gui, new RndGenerator());

            gui.Init();

            DoReset('A', controller, "Insert coin");
            DoGoStop('B', controller, "Insert coin");
            DoTicks('C', controller, 1, "Insert coin");

            DoInsertCoin('D', controller, "Press GO!");

            DoTicks('E', controller, 1, "Press GO!");
            DoInsertCoin('F', controller, "Press GO!");

            randomNumber = 117;
            DoGoStop('G', controller, "Wait...");

            DoTicks('H', controller, randomNumber - 1, "Wait...");

            DoTicks('I', controller, 1, "0.00");
            DoTicks('J', controller, 1, "0.01");
            DoTicks('K', controller, 11, "0.12");
            DoTicks('L', controller, 111, "1.23");

            DoGoStop('M', controller, "1.23");

            DoTicks('N', controller, 299, "1.23");

            DoTicks('O', controller, 1, "Insert coin");

            DoInsertCoin('P', controller, "Press GO!");

            randomNumber = 167;
            DoGoStop('Q', controller, "Wait...");
            
            DoTicks('R', controller, randomNumber - 1, "Wait...");
            DoGoStop('S', controller, "Insert coin");
            
            gui.Init();
            DoReset('T', controller, "Insert coin");
                        
            randomNumber = 123;
            DoInsertCoin('U', controller, "Press GO!");
            
            gui.Init();
            DoReset('V', controller, "Insert coin");
                        
            randomNumber = 123;
            DoInsertCoin('W', controller, "Press GO!");
            DoGoStop('X', controller, "Wait...");
            
            gui.Init();
            DoReset('Y', controller, "Insert coin");

            
            randomNumber = 137;
            DoInsertCoin('Z', controller, "Press GO!");
            DoGoStop('a', controller, "Wait...");
            DoTicks('b', controller, randomNumber + 98, "0.98");
            
            gui.Init();
            DoReset('c', controller, "Insert coin");

            
            randomNumber = 119;
            DoInsertCoin('d', controller, "Press GO!");
            DoGoStop('e', controller, "Wait...");
            DoTicks('f', controller, randomNumber + 135, "1.35");
            DoGoStop('g', controller, "1.35");
            
            gui.Init();
            DoReset('h', controller, "Insert coin");

            
            randomNumber = 120;
            DoInsertCoin('i', controller, "Press GO!");
            DoGoStop('j', controller, "Wait...");
            DoTicks('k', controller, randomNumber + 199, "1.99");
            DoTicks('l', controller, 50, "2.00");
        }

        private static void DoReset(char ch, IController controller, string msg)
        {
            try
            {
                controller.Init();
                GetMessage(ch, msg);
            }
            catch (Exception exception)
            {
                Console.WriteLine("test {0}: failed with exception {1})", ch, msg, exception.Message);
            }
        }

        private static void DoGoStop(char ch, IController controller, string msg)
        {
            try
            {
                controller.GoStopPressed();
                GetMessage(ch, msg);
            }
            catch (Exception exception)
            {
                Console.WriteLine("test {0}: failed with exception {1})", ch, msg, exception.Message);
            }
        }

        private static void DoInsertCoin(char ch, IController controller, string msg)
        {
            try
            {
                controller.CoinInserted();
                GetMessage(ch, msg);
            }
            catch (Exception exception)
            {
                Console.WriteLine("test {0}: failed with exception {1})", ch, msg, exception.Message);
            }
        }

        private static void DoTicks(char ch, IController controller, int n, string msg)
        {
            try
            {
                for (int t = 0; t < n; t++) controller.Tick();
                GetMessage(ch, msg);
            }
            catch (Exception exception)
            {
                Console.WriteLine("test {0}: failed with exception {1})", ch, msg, exception.Message);
            }
        }

        private static void GetMessage(char ch, string msg)
        {
            if (msg.ToLower() == displayText.ToLower())
            {
                Console.WriteLine("test {0}: passed successfully", ch);
                passed++;
            }
            else
                Console.WriteLine("test {0}: failed with message ( expected {1} | received {2})", ch, msg, displayText);
        }

        private class DummyGui : IGui
        {

            private IController controller;

            public void Connect(IController controller)
            {
                this.controller = controller;
            }

            public void Init()
            {
                displayText = "?reset?";
            }

            public void SetDisplay(string msg)
            {
                displayText = msg;
            }
        }

        private class RndGenerator : IRandom
        {
            public int GetRandom(int from, int to)
            {
                return randomNumber;
            }
        }

    }

}
