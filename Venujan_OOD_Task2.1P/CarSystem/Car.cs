using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem
{
    class Car
    {
        //Instance Variables
        private double fuelRate;
        private double fuelLoad = 0;
        private double totalMiles  = 0;

        //Constants
        private const double FUEL_COST = 3.82;  

        //Constructors
        public Car(double Rate, double Load, double Miles)
        {
            this.fuelRate = Rate;
            this.fuelLoad = Load;
            this.totalMiles = Miles;
        }

        //Accessors
        public double getFuel()
        {
            return fuelLoad;
        }

        public double getFuelRate()
        {
            return fuelRate;
        }

        public double getTotalMiles()
        {
            return totalMiles;
        }

        //Mutators 
        public void setTotalMiles(double TotalMiles)
        {
            this.totalMiles = TotalMiles;
        }

        //Private Methods
        private double calcCost()
        {
            double cost = this.fuelLoad * FUEL_COST;
            return cost; //Does not store the cost
        }

        private double convertToLitres(double gallons)
        {
            double liters = gallons * 4.546;
            return liters;
        }

        //Public Methods
        public string printFuelCost()
        {
            return this.calcCost().ToString("C");
        }

        public void addFuel(double fuelIntake)
        {
            this.fuelLoad += fuelIntake;
            this.printFuelCost();
        }
        
   
        public void drive(double miles)
        {
            double gallonSpent;
            double litreSpent;

            Console.WriteLine("Before driving          " + miles + "miles");
            Console.WriteLine("Fuel efficiency:        " + this.fuelRate);
            Console.WriteLine("Fuel load (in litres):   " + this.fuelLoad);
            Console.WriteLine("The total miles driven: " + this.totalMiles);

            Console.WriteLine("\nAfter journey...");

            this.totalMiles += miles;

            Console.WriteLine();
            gallonSpent = (miles / this.fuelRate);
            Console.WriteLine("The gallons spent in " + miles + " miles: " +  gallonSpent);

            litreSpent = convertToLitres(gallonSpent);
            Console.WriteLine("The litres spent in " + miles + " miles: " + litreSpent);

            this.fuelLoad -= litreSpent;
            Console.WriteLine();
            Console.WriteLine("After driving           " + miles + "miles");
            Console.WriteLine("Fuel efficiency:        " + this.fuelRate);
            Console.WriteLine("Fuel load (in litres):  " + this.fuelLoad);
            Console.WriteLine("The total miles driven: " + this.totalMiles);
            Console.WriteLine("Total cost:             " + printFuelCost());

        }


    }
}
