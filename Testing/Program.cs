using System;

namespace Testing
{
    abstract class hello
    {
        public abstract void student();

    }

    class Program:hello
    {

        public override void student()
        {
            Console.WriteLine("this is abstract method with abstract class");

        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine("==========================");
            Program pg = new Program();
            Console.WriteLine("Abstract method initialized");
            pg.student();

            
            Console.ReadLine();


        }
    }
}
