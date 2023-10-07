namespace Without_Inheritance
{
    internal class ZooPark
    {
        static void Main(string[] args)
        {   
            /*
             * Animal williamWolf = new Animal("William the wolf",
             *   "Meat", "Dog Village", 50.6, 9, "Grey");
             */

            /*
             * Animal tonyTiger = new Animal("Tony the Tiger", "Meat",
             * "Cat Land", 110, 6, "Orange and White");
             */

            /*
             * Animal edgarEagle = new Animal("Edgar the Eagle", "Fish",
             *   "Bird Mania", 20, 15, "Black");
             */

            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat",
                "Cat Land", 110, 6, "Orange and White", "Siberoan", "White");

            Wolf williamWolf = new Wolf("William the Wolf", "Meat",
                "Dog Village", 50.6, 9, "Grey");

            Eagle eadgarEagle = new Eagle("Edgar the Eagle", "Fish", 
                "Bird Manis", 20, 15, "Black", "Harpy", 98.5);

            Lion liamLion = new Lion("Liam the Lion", "Meat",
                "Jungle dome", 140, 5, "Golden yellow", "saharan");

            Penguine cobellPenguin = new Penguine("Cobell the Penguin",
                "Fish", "Snow Cap", 19, 14, "Black", "Artic", 70);

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");
            Console.WriteLine("baseAnimal");
            baseAnimal.sleep();
            baseAnimal.eat();
            baseAnimal.makeNoise();
            baseAnimal.mate();

            Console.ReadLine();

            Console.WriteLine("Tiger");
            tonyTiger.sleep();
            tonyTiger.eat();
            tonyTiger.makeNoise();
            tonyTiger.mate();

            Console.ReadLine();

            Console.WriteLine("Wolf");
            williamWolf.sleep();
            williamWolf.eat();
            williamWolf.makeNoise();
            williamWolf.mate();

            Console.ReadLine();

            Console.WriteLine("Eagle");
            eadgarEagle.sleep();
            eadgarEagle.eat();
            eadgarEagle.makeNoise();
            eadgarEagle.mate();
            eadgarEagle.layEgg();
            eadgarEagle.fly();
            Console.ReadLine();

            Console.WriteLine("Checking feline class");
            baseAnimal.sleep();
            tonyTiger.sleep();
            williamWolf.sleep();
            eadgarEagle.sleep();
            tonyTiger.eat();

            Console.ReadLine();

            Console.WriteLine("Testing lion");
            liamLion.sleep();
            liamLion.eat();
            liamLion.makeNoise();
            liamLion.mate();

            Console.ReadLine();
            Console.WriteLine("Testing penguine");
            cobellPenguin.sleep();
            cobellPenguin.eat();
            cobellPenguin.makeNoise();
            cobellPenguin.mate();
            cobellPenguin.fly();


        }
    }
}