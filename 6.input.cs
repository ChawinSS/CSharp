using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What your name");
           String name = Console.ReadLine();
           
            Console.WriteLine("What your age");
           int age = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Hello " + name + " Your age is " + age);

            Console.ReadKey();
        }
    }
}