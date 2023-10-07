namespace GuessTheOuput
{
    class A
    {
        public virtual void m1()
        {
            Console.WriteLine("A's M1");

        }

        public void m2() 
        {
            Console.WriteLine("A's M2");
        }
    }

    class B : A
    {
        public override void m1()
        {
            Console.WriteLine("B's M1");
        }
        public void m2() { Console.WriteLine("B's M2"); }

    }

    class C : B
    {
        public void m1()
        {
            Console.WriteLine("C's is M1");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            A a = new A();
            B b = new B();
            C c = new C();

            // Part A
            Console.WriteLine("Part A");
            a.m1();
            b.m1();
            */

           A a = new A();
           B b = new B();
           C c = new C();

            // Part B
            Console.WriteLine();
            Console.WriteLine("Part B");
            a.m2();
            b.m2();
            c.m1();
            c.m2();


        }
    }
}