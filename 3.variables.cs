using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 28; // whole integer
            double height = 300.5; // decimal number
            bool alive = false; //true or false
            char symbol = '@'; // single character
            String name = "Chawin"; // a series of characters

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z+"\n");
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();
        }
    }
}