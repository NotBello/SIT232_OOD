using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void eat()
        {
            //Code for the animal to eat
        }

        public void sleep()
        {
            //Code for the animal to sleep
        }

        public void makeNoise()
        {
            //Code for the animal to make a noise
        }

        public void makeLionNoise()
        {
            //Code for the lions to roar
        }

        public void makeEagleNoise()
        {
            //Code for the eagles to cry
        }

        public void makeWolfNoise()
        {
            //Code for the wolves to howl
        }

        public void eatMeat()
        {
            //Code for the animal to eat meat
        }

        public void eatBerries()
        {
            //Code for the animal to eat berries
        }
    }
}
