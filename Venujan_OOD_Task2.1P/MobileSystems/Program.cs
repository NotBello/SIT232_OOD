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
        }
    }
}