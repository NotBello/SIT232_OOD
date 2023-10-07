using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Without_Inheritance
{
    class Animal
    {
        // Declaring fields
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        // Animal Constructor
        public Animal(String name,
            String diet, String location,
            double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        // Public methods
        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public void sleep()
        {
            Console.WriteLine("An animal sleeps");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }

        public virtual void mate()
        {
            Console.WriteLine("An animal mates");
        }



    }

    class Bird : Animal
    {
        private String species;
        private double wingSpan;
        public Bird(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) :
            base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Whistle");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 1lbs of fish");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with bird");
        }

        public void layEgg()
        {
            Console.WriteLine("I can lay eggs");
        }

        public virtual void fly()
        {
            Console.WriteLine("I can fly");
        }
    }

    class Penguine : Bird
    {
        public Penguine(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) :
            base(name, diet, location, weight, age, colour, species, wingSpan)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Alarm");
        }

        public override void fly()
        {
            Console.WriteLine("Cannot fly");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of fish");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with another penguin");
        }
    }

    class Feline : Animal
    {
        private String species;

        public Feline(String name, String diet, String location, double weight, int age, String colour, String species) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }
    }

    class Lion : Feline
    {
        public Lion(String name, String diet, String location, double weight, int age, String colour, String species) :
            base(name, diet, location, weight, age, colour, species)
        {            
        }

        public override void makeNoise()
        {
            Console.WriteLine("Lion ROAR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 40lbs of meat");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with another lioness");
        }


    }

    class Tiger : Feline
    {
        // private String species;
        private String colorStripes;

        public Tiger(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) :
            base(name, diet, location, weight, age, colour, species)
        {
            // this.species = species;
            this.colorStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("ROAR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with another tigeress");
        }
    }

    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location, double weight, int age, String colour) : base(name, diet, location, weight, age, colour) { }

        public override void makeNoise()
        {
            Console.WriteLine("Hoooowl");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with another wolf");
        }

    }

    class Eagle : Bird
    {
        private String species;
        private double wingSpan;

        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) :
            base(name, diet, location, weight, age, colour, species, wingSpan)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Whistle");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 1lbs of fish");
        }

        public override void mate()
        {
            Console.WriteLine("I can mate with another eagle");
        }

        /*
        public void layEgg()
        {
            Console.WriteLine("I can lay eggs");
        }*/

        public void fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
