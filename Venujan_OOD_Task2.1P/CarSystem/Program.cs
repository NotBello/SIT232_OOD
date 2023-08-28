using System;

namespace CarSystem
{
    class CarProgram
    {
        static void Main(string[] args)
        {
            
            Car bello = new Car(38.4, 50, 0);

            double fuel = bello.getFuel();
            double fuelInGallons = fuel / 4.546;
            double mileLimit = fuelInGallons * bello.getFuelRate();

            Console.WriteLine("You can travel upto " + mileLimit.ToString() + " miles, with the " + bello.getFuel() + " litres");

            Console.WriteLine("\nbello starts journey...");
            bello.drive(300);

            Console.WriteLine("\nRefuelling for 20 lites");
            bello.addFuel(20);
            Console.WriteLine("\nYou can travel upto " + mileLimit.ToString() + " miles, with the " + bello.getFuel() + " litres");

            Console.WriteLine("\nbello starts journey...");
            bello.drive(200);

        }
    }
}