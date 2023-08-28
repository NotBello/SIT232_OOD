using System;

namespace MobileEnv
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung S1 Ultra", "07712223344");

            Console.WriteLine("Account Type: " + jimMobile.getAcctype() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());
            
            Console.WriteLine("\nChecking Mutators: ");
            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iPhone 11 Max");
            jimMobile.setNumber("07713334466");
            jimMobile.setBalance(15.50);

            Console.WriteLine();
            Console.WriteLine("Account Type: " + jimMobile.getAcctype() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());

            Console.WriteLine("\nChecking functions to add credit, make calls, and send text");
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);

            Console.WriteLine();
            Console.WriteLine("Account Type: " + jimMobile.getAcctype() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());

            Console.WriteLine();
            Console.WriteLine("Testing with a new Mobile account for Bello");
            Mobile belloMobile = new Mobile("Monthly", "iPhone 14 Pro", "07059477054");
            belloMobile.setBalance(2000);
            Console.WriteLine("Account Type: " + belloMobile.getAcctype() + "\nMobile Number: "
                + belloMobile.getNumber() + "\nDevice: " + belloMobile.getDevice() + "\nBalance: "
                + belloMobile.getBalance());

            Console.WriteLine();
            belloMobile.makeCall(10);
            belloMobile.sendText(4);

            Console.WriteLine();
            Console.WriteLine("Account Type: " + belloMobile.getAcctype() + "\nMobile Number: "
                + belloMobile.getNumber() + "\nDevice: " + belloMobile.getDevice() + "\nBalance: "
                + belloMobile.getBalance());

        }
    }
}