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
            Console.ReadLine();
        }
    }
}