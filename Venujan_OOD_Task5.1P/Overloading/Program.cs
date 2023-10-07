namespace Overloading
{

    class OverloadClass
    {
        public void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }

        public void methodToBeOverloaded(String name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadClass test = new OverloadClass();
            test.methodToBeOverloaded("test");

            Console.WriteLine();

            test.methodToBeOverloaded("test", 19);
            

        }
    }
}