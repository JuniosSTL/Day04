using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int(); // ==> int a; //legacy
            float b = new float(); // == flat b;

            Program p = new Program();
            p.Add();

            A.Display();
            A.display = 100;
        }

        void Add()
        {

        }
    }

    class A
    {
        public static void Display()
        {
            Console.WriteLine("Class A");
        }

        public static int display;
    }

    class B
    {
        void Test()
        {
            A.display = 20;
        }


        public static void Display()
        {
            Console.WriteLine("Class B");
        }
    }

    class C
    {
    }
}
